using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfObjects
{
    class Student
    {
        private string fullName;
        private string major;
        private int yearOfBirth;

        public string FullName
        {
            set { fullName = value; }
            get { return this.fullName; }
        }

        public string Major
        {
            set { major = value; }
            get { return this.major; }
        }

        public int YearOfBirth
        {
            set { yearOfBirth = value; }
            get { return this.yearOfBirth; }
        }
    }
}
