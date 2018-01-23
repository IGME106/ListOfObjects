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

        public Student()                                                // Default constructor
        {
            FullName = "Non-specified Name";
            Major = "Non-specified Major";
            YearOfBirth = 1900;
        }

        public Student(string fullName, string major, int yearOfBirth)  // Parameterized constructor
        {
            FullName = fullName;
            Major = major;
            YearOfBirth = yearOfBirth;
        }

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

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Name: " + this.FullName);
            stringBuilder.AppendLine("Major: " + this.Major);
            stringBuilder.AppendLine("Year: " + this.YearOfBirth);

            return (stringBuilder.ToString());
        }
    }
}
