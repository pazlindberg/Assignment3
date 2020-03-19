using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Animal
    {
        private int age;
        private string name;
        private double weight;

        public Animal(int a, string s, double w) { age = a; name = s; weight = w; }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public virtual string Stats()
        {
            string stats = Name + "\t" + Age.ToString() + "\t" + Weight.ToString();
            return (stats);
        }
    }
}
