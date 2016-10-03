using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNamesForm {
    public interface IListaNomes {
        void add(object name);
        void erase();
        string toString();
    }
}
