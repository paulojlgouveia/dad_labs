using CommonTypesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;


namespace ServerConsoleApplication {
	class ServerProgram {
		static void Main(string[] args) {
			Console.WriteLine("[server] : started.");

			TcpChannel channel = new TcpChannel(8086);
			ChannelServices.RegisterChannel(channel, true);

			RemotingConfiguration.RegisterWellKnownServiceType(
				typeof(Server),
				"ChatServer",
				WellKnownObjectMode.Singleton);

			ServerInterface _server = new Server();


			Console.WriteLine("[server] : closed.\r\npress <return> to exit.");
			Console.ReadLine();
		}
	}
}
