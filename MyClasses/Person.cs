using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses {
    [Serializable]
    public abstract class Person {
        #region Private Variables
        protected String _FirstName;
        private String _MiddleName;
        private String _LastName = "Smith";
        private DateTime _DateOfBirth;
        private Colors _EyeColor;
        private double _Height;
        #endregion

        #region Enums

        public enum Colors {
            Black,
            Brown,
            Green,
            Blue = 77,
            Gray = 56,
            Hazel,
            BlueAndGreen
        }
        #endregion

        #region Constructors
        public Person() {
            FirstName = "Not";
            LastName = "Set";
        }

        /// <summary>
        /// Create a person
        /// </summary>
        /// <param name="fName">First name of person</param>
        public Person(string fName) {
            SetStartingValues(fName, "Unknown", DateTime.MinValue);
        }
        /// <summary>
        ///// Create a person
        ///// </summary>
        ///// <param name="fName">First name of person</param>
        ///// <param name="lName">Last name of person</param>
        //public Person(string fName, string lName) {
        //    SetStartingValues(fName, lName, DateTime.MinValue);

        //}
        /// <summary>
        /// Create a person
        /// </summary>
        /// <param name="fName">First name of person</param>
        /// <param name="lName">Last name of person</param>
        /// <param name="dob">Person's date they were born.</param>
        public Person(string fName, string lName, DateTime dob) {
            SetStartingValues(fName, lName, dob);
        }

        private void SetStartingValues(string fName, string lName,
                                        DateTime dob) {
            FirstName = fName;
            LastName = lName;
            DateOfBirth = dob;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Set and Gets the person's first name.
        /// </summary>
        public string FirstName {
            get {
                string value = _FirstName;
                return value;
            }
            set {
                if (value == "") {
                    _FirstName = "Bob";
                } else {
                    _FirstName = value;
                }
            }
        }
        /// <summary>
        /// Set and Gets the person's middle name.
        /// </summary>
        public string MiddleName {
            get {
                string value = _MiddleName;
                return value;
            }
            set {
                if (value == "") {
                    _MiddleName = "Bob";
                } else {
                    _MiddleName = value;
                }
            }
        }
        /// <summary>
        /// Set and Gets the person's last name.
        /// </summary>
        public string LastName {
            get {
                string value = _LastName;
                return value;
            }
            set {
                if (value == "") {
                    _LastName = "Smith";
                } else {
                    _LastName = value;
                }
            }
        }
        /// <summary>
        /// Set and Gets the person's birth date.
        /// </summary>
        public DateTime DateOfBirth {
            get {
                return _DateOfBirth;
            }
            set {
                _DateOfBirth = value;
            }
        }
        /// <summary>
        /// Get and Set the person's height in inches.
        /// </summary>
        public double Height {
            get {
                return _Height;
            }
            set {
                if (value > 0) {
                    _Height = value;
                } else {
                    _Height = 0;
                }
            }
        }

        /// <summary>
        /// Get and Set the person's eye color.
        /// </summary>
        public Colors EyeColor {
            get { return _EyeColor;
            }
            set {
                _EyeColor = value;
            }
        }
        /// <summary>
        /// Get Person's full name
        /// </summary>
        public string FullName {
            get {
                return string.Format("{0} {1} {2}",
                    FirstName, MiddleName, LastName);
            }
        }

        /// <summary>
        /// Get the age of a person in whole years.
        /// </summary>
        public int Age {
            get {
                TimeSpan timeAlive = DateTime.Now - _DateOfBirth;
                double daysOfLife = timeAlive.TotalDays;
                return (int)(daysOfLife / 365);
            }
        }



        #endregion

        #region Methods
        public virtual string Yell() {
            return "Boo";
        }

        public abstract string Call();

        #endregion

        public override string ToString() {
            return FullName;
        }

    }
}
