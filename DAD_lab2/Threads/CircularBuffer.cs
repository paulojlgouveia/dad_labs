using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads {
	public class CircularBuffer<T> {

		private T[] buffer;
		private int nextFree;
		private int nextRead;

		private int ocupied;

		public CircularBuffer(int length) {
			buffer = new T[length];
			nextFree = 0;
			nextRead = 0;
			ocupied = 0;
		}

		public void Add(T thing) {
			lock (this) {
				while (ocupied == buffer.Length) {
					Monitor.Wait(this);
				}

				buffer[nextFree] = thing;
				nextFree = (nextFree + 1) % buffer.Length;
				ocupied++;

				Monitor.Pulse(this);
			}
		}

		public T GetNext() {
			T returnVal;

			lock (this) {
				while (ocupied == 0) {
					Monitor.Wait(this);
				}

				returnVal = buffer[nextRead];
				nextRead = (nextRead + 1) % buffer.Length;
				ocupied--;

				Monitor.Pulse(this);
			}
				return returnVal;
		}
	}

}
