using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads {

	delegate void ThrWork();

	class Program {

		static void Main(string[] args) {

			Console.WriteLine("C - Threads\r\n");
			Console.ReadLine();

			ThrPool tpool = new ThrPool(5, 10);
			ThrWork work = null;
			A a;
			B b;
			for (int i = 0; i < 5; i++) {
				a = new A(i);
				b = new B(i);
				tpool.AssyncInvoke(new ThrWork(a.DoWorkA));
				tpool.AssyncInvoke(new ThrWork(b.DoWorkB));
			}

			Console.ReadLine();

		}
	}
}
