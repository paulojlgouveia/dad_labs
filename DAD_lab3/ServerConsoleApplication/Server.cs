using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

using CommonTypesLibrary;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

namespace ServerConsoleApplication {
	public class Server : MarshalByRefObject, ServerInterface {
		
		ConcurrentDictionary<string,string> _clients = null;


		public Server() {
			_clients = new ConcurrentDictionary<string, string>();
		}


		public string ping() {
			return "pong";
		}

		public void register(string name, string url) {
			_clients.TryAdd(name, url);
		}

		public void send(string name, string message) {

			ClientInterface RemoteClient = null;

			foreach (KeyValuePair<string,string> client in _clients) {
				if (client.Key.Equals(name)) {
					continue;

				} else {
					RemoteClient = (ClientInterface) Activator.GetObject(
																	typeof(ClientInterface),
																	client.Value );

					try {
						RemoteClient.propagate(message);

					} catch (SocketException) {
						string str = "\r\nCould not locate client:"
									+ "\r\n\tname: " + name + "\r\n\tat: " + client.Value;

						System.Console.WriteLine(str);
					}
				}

			}


			throw new NotImplementedException();
		}

		// Gives infinit life span to the registered object
		public override object InitializeLifetimeService() {
			return null;
		}

	}
}

