using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommonTypesLibrary {
	public interface ClientInterface {

		string ping();

		void propagate(string message);

		void sendMessage(string message);
	}
}

