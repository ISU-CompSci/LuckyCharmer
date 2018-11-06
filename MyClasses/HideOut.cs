using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses {
   public class HideOut<AType> {
        private List<AType> _Members;


        public List<AType> Members {
            get {
                if (_Members == null) _Members = new List<AType>();
                return _Members;
            }
            set { _Members = value; }
        }

        public AType GetFirstMember() {
            return _Members[0];
        }

    }
}
