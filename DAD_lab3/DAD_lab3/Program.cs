using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD_lab3 {
	class Program {
		static void Main(string[] args) {

			var serverStartInfo = new ProcessStartInfo(@"ServerConsoleApplication.exe");
			serverStartInfo.WorkingDirectory = @"C:\Users\daedalus\Documents\Visual Studio 2015\Projects\dad_labs\DAD_lab3\ServerConsoleApplication\bin\Debug";
			Process.Start(serverStartInfo);

			var cliet1StartInfo = new ProcessStartInfo(@"ClientFormApplication.exe");
			cliet1StartInfo.WorkingDirectory = @"C:\Users\daedalus\Documents\Visual Studio 2015\Projects\dad_labs\DAD_lab3\ClientFormApplication\bin\Debug";
			Process.Start(cliet1StartInfo);

			var cliet2StartInfo = new ProcessStartInfo(@"ClientFormApplication.exe");
			cliet2StartInfo.WorkingDirectory = @"C:\Users\daedalus\Documents\Visual Studio 2015\Projects\dad_labs\DAD_lab3\ClientFormApplication\bin\Debug";
			Process.Start(cliet2StartInfo);


		}
	}
}
