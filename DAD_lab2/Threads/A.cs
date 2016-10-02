using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads {
	class A {

		private int _id;

		public A(int id) {
			_id = id;
		}

		public void DoWorkA() {
			Console.WriteLine("A-{0}", _id);
		}

	}
}
