using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads {
	class B {

		private int _id;

		public B(int id) {
			_id = id;
		}

		public void DoWorkB() {
			Console.WriteLine("B-{0}", _id);
		}

	}
}
