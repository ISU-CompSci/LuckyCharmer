using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses {
   public class Prison<T,J> {
        private J _Jailor;
        private List<T> _Inmates;
        public J Jailor {
            get { return _Jailor; }
            set { _Jailor = value; }
        }

        public List<T> Inmates {
            get {
                if (_Inmates == null) _Inmates = new List<T>();
                    return _Inmates;
            }
            set { _Inmates = value; }
        }


    }
}
