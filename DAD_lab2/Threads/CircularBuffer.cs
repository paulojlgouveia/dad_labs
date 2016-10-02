using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads {
	public class CircularBuffer<T> {

		private T[] buffer;
		private int nextFree;
		private int nextRead;

		public CircularBuffer(int length) {
			buffer = new T[length];
			nextFree = 0;
			nextRead = 0;
		}

		public void Add(T thing) {
			buffer[nextFree] = thing;
			nextFree = (nextFree + 1) % buffer.Length;
		}

		public T GetNext() {
			int currentRead = nextRead;
			nextRead = (nextRead + 1) % buffer.Length;

			return buffer[currentRead];
		}
	}

}
