using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Horse : Animal
    {
        private string colour;

        public Horse(int a, string s, double w, string l) : base(a, s, w)
        {
            Colour = l;
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public override string Stats()
        {
            string stats = base.Stats() + "\t" + Colour;
            return (stats);
        }
    }
}
