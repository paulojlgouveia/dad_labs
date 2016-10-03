using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace ListOfNamesForm {
    public class IListaNomesImpl : IListaNomes {

        ArrayList array = new ArrayList();

        public IListaNomesImpl() {
        }

        public void add(object name) {
            array.Add(name);
        }

        public void erase() {
            array.Clear();
        }

        public string toString() {
            string result = "";

            foreach (object obj in array) {
                result = result + obj.ToString();
            }

            return result;
        }
    }
}
