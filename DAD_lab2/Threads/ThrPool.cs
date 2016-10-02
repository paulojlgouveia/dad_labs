using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads {


	class ThrPool {

		CircularBuffer<ThrWork> buffer = null;

		public ThrPool(int thrNum, int bufSize) {
			// TODO
			buffer = new CircularBuffer<ThrWork>(bufSize);
		}

		public void AssyncInvoke(ThrWork action) {
			// TODO
		}

	}
}
