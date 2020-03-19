using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class ShitBehindKeyboardError : UserError
    {
        public override string UEMessage()
        {
            return "Shit behind keyboard error!";
        }
    }
}
