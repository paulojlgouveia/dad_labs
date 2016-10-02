using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events {
	class Program {
			// this is the method that should be called when the slider is moved
			static void slider_Move(object source, MoveEventArgs e) {
				// TODO
			}

		static void Main() {

			Console.WriteLine("B - Events\r\n");
			Console.ReadLine();

			Slider slider = new Slider();

			// TODO: register with the Move event

			// these are two simulate slider moves
			slider.Position = 20;
			slider.Position = 60;

			Console.ReadLine();

		}
	}
}
