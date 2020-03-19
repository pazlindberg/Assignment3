using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Bird : Animal
    {
        private string lang;

        public Bird(int a, string s, double w, string l) : base(a, s, w) 
        {
            Lang = l;
        }

        public string Lang
        {
            get { return lang; }
            set { lang = value; }
        }

        public override string Stats()
        {
            string stats = base.Stats() + "\t" + Lang;
            return (stats);
        }
    }
}
