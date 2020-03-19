using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Hedgehog : Animal
    {
        private double velocity;

        public Hedgehog(int a, string s, double w, double l) : base(a, s, w)
        {
            Velocity = l;
        }

        public double Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public override string Stats()
        {
            string stats = base.Stats() + "\t" + Velocity; 
            return (stats);
        }
    }
}
