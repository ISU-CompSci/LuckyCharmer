using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses {
    class Jet : IFlyable {
        private Person[] _Passengers;

        private Wing _RightWing = new Wing() { Length = 10 };
        private Wing _LeftWing = new Wing() { Length = 10 };

        public Wing RightWing {
            get { return _RightWing; }
            set { _RightWing = value; }
        }
        public Wing LeftWing {
            get { return _LeftWing; }
            set { _LeftWing = value; }
        }


        public Person[] Passengers {
            get { return _Passengers; }
            set { _Passengers = value; }
        }


        //private int _MaxPassengers;
        private int _PassengerCount;

        public Jet(int pass) {
            //_MaxPassengers = pass;
            _Passengers = new Person[pass];
        }

        public int MaxPassengers {
            get {
                return _Passengers.Count(); //_MaxPassengers;
            }
        }


        public int PassengerCount {
            get { return _PassengerCount; }
        }


        public string Flies() {
            return "Vrrrooom.";
        }

        public static string operator +(Jet j, Person p) {
            //return "DooppyDoo";
            if (j.PassengerCount == j.MaxPassengers) {
                return "Get Out! " + p.FullName;
            } else {
                j._PassengerCount++;
                return "All Aboard " + p.FullName;
            }
            //return "Something Happened";

        }

        public int GiveMeANumber() {
            Random rnd = new Random();
            return rnd.Next(-10, 10);
        }

        public int GetPositive(int numb) {
            if (numb < 0) return numb * -1;
            return numb;
        }


    }
}
