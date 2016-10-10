using System;
using System.Collections.Concurrent;

namespace RemotingSample {

	public class MyServer : MarshalByRefObject  {

		ConcurrentDictionary<string, string> _clients = null;

		MyServer() {

			_clients = new ConcurrentDictionary<string, string>();

		}

		void Register(string name, string url) {


		}

		void Send(string name, string message) {


		}
    
		void Propagate(string message) {


		}


		public string MetodoOla() {
			 return "ola!";
		}
	 }
}