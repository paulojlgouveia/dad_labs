using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using CommonTypesLibrary;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

namespace ClientFormApplication {
	public class Client : MarshalByRefObject, ClientInterface {

		private TcpChannel _channel = null;
		private ServerInterface _server = null;

		private string _username = null;
		private string _port;


		public Client(string username, string port) {

			_username = username;
			_port = port;

			_channel = new TcpChannel(Int32.Parse(_port));
			ChannelServices.RegisterChannel(_channel,true);

			//RemotingConfiguration.RegisterWellKnownServiceType(
			//	typeof(Client),
			//	"Client",
			//	WellKnownObjectMode.SingleCall);

			RemotingServices.Marshal(
				this,
				"Client",
				typeof(ClientInterface));

			_server = (ServerInterface)Activator.GetObject( typeof(ServerInterface),
															"tcp://localhost:8086/ChatServer");

			_server.register(username, "tcp://localhost:"+port+ "/Client");
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

			//form.invoke(add message)
			//https://msdn.microsoft.com/en-us/library/zyzhdc6b(v=vs.110).aspx

			//Console.WriteLine("sjsjsjsjsjsjssj");
			//throw new NotImplementedException();
		}

		public void sendMessage(string message) {
			_server.send(_username, message);
		}

	}

}

