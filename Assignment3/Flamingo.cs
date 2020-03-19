using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Flamingo : Bird
    {
        private bool likesTrump;

        public Flamingo(int a, string s, double w, string l, bool lt) : base(a, s, w, l)
        {
            LikesTrump = lt;
        }

        public bool LikesTrump
        {
            get { return likesTrump; }
            set { likesTrump = value; }
        }

        public override string Stats()
        {
            string stats = base.Stats() + "\t" + LikesTrump.ToString();
            return (stats);
        }
    }
}
