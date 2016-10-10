using CommonTypesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFormApplication {

	static class ClientProgram {

		// import to be able to close the console when no longer needed
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int FreeConsole();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Console.WriteLine("[client] : started.");

			Console.WriteLine("username: ");
			string username = Console.ReadLine();
			Console.WriteLine("port: ");
			int port = Int32.Parse(Console.ReadLine());

			ClientInterface _client = new Client(username, port);

			FreeConsole();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());

			
			Console.WriteLine("[client] : closed.\r\npress <return> to exit.");
			Console.ReadLine();
		}
	}
}
