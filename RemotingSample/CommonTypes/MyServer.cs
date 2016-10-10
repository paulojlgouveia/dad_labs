using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Sockets;

namespace RemotingSample {

	public class MyServer : MarshalByRefObject {

		Dictionary<string, string> _clients = null;

		MyServer() {

			_clients = new Dictionary<string, string>();

		}

		void Register(string name, string url) {
			_clients.Add(name, url);

		}

		void Send(string name, string message) {
			foreach(KeyValuePair<string, string> client in _clients) {
				if (client.Key.Equals(name))
					continue;

				MyClient obj = (MyClient)Activator.GetObject(
					typeof(MyClient),
					client.Value);

				try {
					obj.Propagate(message);

				} catch (SocketException) {
					System.Console.WriteLine("Could not locate server");
				}

			}
		}

		public string MetodoOla() {
			return "ola!";
		}
	}
}