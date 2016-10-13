using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace classloader_serious {
	class Program {
		static void Main(string[] args) {

			Assembly _assembly = null;
			Type _type = null;
			Object _obj = null;
			MethodInfo _method = null;

			Console.Write("dll: ");
			//string _dll = Console.ReadLine();
			string _dll = @"C:\Users\daedalus\Documents\Visual Studio 2015\Projects\classloader_serious\CustomOperatorExamplaes\bin\Debug\CustomOperatorExamplaes.dll";
			Console.WriteLine(_dll);

			_assembly = Assembly.LoadFrom(_dll);


			Console.Write("class: ");
			//string _class = Console.ReadLine();
			string _class = "CustomOperatorExamplaes.Basic";
			Console.WriteLine(_class);

			_type = _assembly.GetType(_class);
			_obj = Activator.CreateInstance(_type);


			Console.Write("method: ");
			//string _function = Console.ReadLine();
			string _function = "Repeat";
			Console.WriteLine(_function);

			_method = _type.GetMethod(_function);

			if (_method == null)
				Console.WriteLine(_class + "." + _function + "could not be found.");


			List<string> _list = new List<string>();
			_list.Add("1");
			_list.Add("2");
			_list.Add("3");
			_list.Add("4");
			_list.Add("5");
			_list.Add("\r\n");


			_list.ForEach(Console.WriteLine);
			((List<string>)_method.Invoke(_obj, new Object[] { _list })).ForEach(Console.WriteLine);

		}
	}
}
