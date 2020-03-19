using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Dog : Animal
    {
        private string race;

        public Dog(int a, string s, double w, string l) : base(a, s, w)
        {
            Race = l;
        }

        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        public override string Stats()
        {
            string stats = base.Stats() + "\t" + Race;
            return (stats);
        }

        public string SayObama()
        {
            return ("OBAMA!");
        }
    }
}
