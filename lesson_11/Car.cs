using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11
{
    internal class Car: CarDetail
    {
        public string color;
        public int speed;
        public double engineSize;
        public char status;
        public int price;
        private int year;
        private string brand;

        public int Year
        { 
            get { return year; }
            set { year = Math.Abs(value); }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value.ToUpper(); }
        }

    }
}
