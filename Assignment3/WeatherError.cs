using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class WeatherError : UserError
    {
        public override string UEMessage()
        {
            return "not really user error, it was the weather again..";
        }
    }
}
