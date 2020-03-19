using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Pelican : Bird
    {
        private bool canCarryCoconut;

        public Pelican(int a, string s, double w, string l, bool ccc) : base(a, s, w, l)
        {
            CanCarryCoconut = ccc;
        }

        public bool CanCarryCoconut
        {
            get { return canCarryCoconut; }
            set { canCarryCoconut = value; }
        }
        public override string Stats()
        {
            string stats = base.Stats() + "\t" + CanCarryCoconut.ToString();
            return (stats);
        }
    }
}
