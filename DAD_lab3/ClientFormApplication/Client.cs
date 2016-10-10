using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using CommonTypesLibrary;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

namespace ClientFormApplication {
	public class Client : MarshalByRefObject, ClientInterface {

		private TcpChannel _channel = null;
		private ServerInterface _server = null;

		private string _username = null;
		private int _port;


		public Client(string username, int port) {

			string _username = username;
			int _port = port;

			_channel = new TcpChannel();
			ChannelServices.RegisterChannel(_channel,true);

			_server = (ServerInterface)Activator.GetObject( typeof(ServerInterface),
															"tcp://localhost:8086/ChatServer");
		}

		/*

	 		try
	 		{
	 			Console.WriteLine(obj.MetodoOla());
	 		}
	 		catch(SocketException)
	 		{
	 			System.Console.WriteLine("Could not locate server");
	 		}
		*/

		public string ping() {
			return "pong";
		}

		public void propagate(string message) {

			// form.invoke(add message)

			throw new NotImplementedException();
		}

	}

}

