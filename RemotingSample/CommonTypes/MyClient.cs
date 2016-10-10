using System;
using System.Collections.Concurrent;

namespace RemotingSample {

	public class MyClient : MarshalByRefObject {

		MyClient() {

		}

		public void Propagate(string message) {


		}


		public string MetodoOla() {
			return "ola!";
		}
	}
}