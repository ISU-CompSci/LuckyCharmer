using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses {
   public class Villian : Person {
        private string _Lair;

        public string Lair {
            get { return _Lair; }
            set { _Lair = value; }
        }

        public override string Call() {
            return "Amiga";
        }

        public override string ToString() {
            return "I am bad guy";
        }
    }
}
