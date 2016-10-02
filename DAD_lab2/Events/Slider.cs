using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events {
	// compose.cs

	class Slider {
		private int position;

		public int Position {
			//this is what is run when we change the position
			get { return position; }
			set { position = value; }
		}

	}
}
