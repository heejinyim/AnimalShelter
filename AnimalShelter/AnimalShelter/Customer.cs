using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Customer
    {
        public string LastName;
        public string FirstName;
        private DateTime _Birthday;
        private bool _IsQualified;
        public string Address;
        public string Description;

        public Customer(string lastName, string firstName, DateTime birthday)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this._Birthday = birthday;

            if((Age) >= 18)
            {
                _IsQualified = true;
            }
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
                if(Age >= 18)
                {
                    _IsQualified = true;
                }
            }
        }


        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }

        public bool IsQualified
        {
            get { return _IsQualified; }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
 