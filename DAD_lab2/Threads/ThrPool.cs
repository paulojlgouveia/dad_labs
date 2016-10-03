using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads {


	class ThrPool {

		CircularBuffer<ThrWork> buffer = null;

		public ThrPool(int thrNum, int bufSize) {
			buffer = new CircularBuffer<ThrWork>(bufSize);
			Thread workerThread = new Thread(thrNum);
		}

		public void AssyncInvoke(ThrWork action) {
			buffer.Add(action);
		}

	}

}

