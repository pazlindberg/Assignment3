using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Worm : Animal
    {
        private bool isDangerous;

        public Worm(int a, string s, double w, bool ihz) : base(a, s, w)
        {
            IsDangerous = ihz;
        }

        public bool IsDangerous
        {
            get { return isDangerous; }
            set { isDangerous = value; }
        }
        
        public override string Stats()
        {
            string stats = base.Stats() + "\t" + IsDangerous.ToString(); // ... should probably return something descriptive but.. it wasnt the assignment
            return (stats);
        }
    }


}
