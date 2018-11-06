using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses {
    [Serializable]
   public class SuperHero : Person, IFlyable {
        private string _Power;
        private Citizen _Alias;

        public SuperHero() {
            _FirstName = "Bob";
            LastName = "the Awesome";
        }

        public SuperHero(string fName, string lName)
            : base(fName, lName, new DateTime(2002, 2, 25)) {
            //FirstName = fName;
            //LastName = lName;
        }

        public string Power {
            get {
                return _Power;
            }
            set {
                _Power = value;
            }
        }

        public Citizen Alias {
            get {
                return _Alias;
            }
            set {
                _Alias = value;
            }

        }

        public override string Yell() {
            return "Huzzah!" + base.Yell() ;
        }

        public override string Call() {
            return "Whatz up!";
        }

        public SuperHero CloneMe() {
            //return this; // Shallow copy
            // return new SuperHero(); // New Object
            SuperHero myClone = new SuperHero();
            myClone.FirstName = this.FirstName;
            myClone.LastName = this.LastName;
            myClone.DateOfBirth = this.DateOfBirth;

            return myClone;
        }

        public string Flies() {
            return "Up up and away";
        }

    }
}
