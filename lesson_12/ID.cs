using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12
{
    internal class ID
    {
        string name;
        string surname;
        string country;
        int age;
        char gender;

        public string NAME
        {
            get { return name; }
            set { name = value.ToLower(); }
        }

        public string SURNAME
        {
            get { return surname; }
            set { surname = value.ToUpper(); }
        }

        public string COUNTRY
        {
            get { return country; }
            set {  country = value.ToUpper(); }
        }

        public int AGE
        {
            get { return age; }
            set { age = value; }
        }

        public char GENDER
        {
            get { return gender; }
            set { gender = value; }
        }

        public ID()
        {
            name = "";
            surname = "";
            country = "";
            age = 18;
            gender = 'M';
        }
    }
}
