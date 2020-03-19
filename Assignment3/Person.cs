using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Person
    {
        private int age;
        private double height, weight;
        private string fName, lName;
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }

        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }

        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
    }
}
