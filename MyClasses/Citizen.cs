using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses {
    [Serializable]
    public class Citizen : Person {
        

        public Citizen(string fName, string lName)
          : base(fName, lName, new DateTime(2000, 6, 18)) {
        }

        private SuperHero _SecretIdentity;

        public SuperHero SecretIdentity {
            get { return _SecretIdentity; }
            set { _SecretIdentity = value; }
        }


        public override string Call() {
            return "Hey you Guys!!";
        }
    }
}
