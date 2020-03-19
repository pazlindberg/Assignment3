using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Swan : Bird
    {
        private string favouriteMovie;

        public Swan(int a, string s, double w, string l, string fm) : base(a, s, w, l)
        {
            FavouriteMovie = fm;
        }

        public string FavouriteMovie
        {
            get { return favouriteMovie; }
            set { favouriteMovie = value; }
        }

        public override string Stats()
        {
            string stats = base.Stats() + "\t" + FavouriteMovie;
            return (stats);
        }
    }
}
