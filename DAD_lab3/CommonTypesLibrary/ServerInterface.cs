using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommonTypesLibrary {
	public interface ServerInterface {

		string ping();

		void register(string name, string url);

		void send(string name, string message);

	}
}
