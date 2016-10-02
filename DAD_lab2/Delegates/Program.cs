using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates {


	class Program {

		delegate void MyDelegate(string s);

		static void Main(string[] args) {

			Console.WriteLine("A - Delegates\r\n");
			Console.ReadLine();

			MyDelegate a, b, c, d;

			// Create the delegate object a that references
			// the method Hello:
			a = new MyDelegate(MyClass.Hello);
			// Create the delegate object b that references
			// the method Goodbye:
			b = new MyDelegate(MyClass.Goodbye);
			// The two delegates, a and b, are composed to form c:
			c = a + b;
			// Remove a from the composed delegate, leaving d,
			// which calls only the method Goodbye:
			d = c - a;

			Console.WriteLine("Invoking delegate a:");
			a("A");
			Console.WriteLine("\r\nInvoking delegate b:");
			b("B");
			Console.WriteLine("\r\nInvoking delegate c:");
			c("C");
			Console.WriteLine("\r\nInvoking delegate d:");
			d("D");

			Console.ReadLine();

		}
	}
}
