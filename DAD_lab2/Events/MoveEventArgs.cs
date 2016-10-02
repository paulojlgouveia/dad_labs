using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events {

	// this delegate is the base for the sliders move event
	delegate void MoveEventHandler(object source, MoveEventArgs e);


	// this class contains the arguments of the slider move event
	public class MoveEventArgs : EventArgs {
		// ...
	}

}
