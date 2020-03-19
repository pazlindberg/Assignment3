using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class MomError : UserError
    {
        public override string UEMessage()
        {
            return "your mom!";
        }
    }
}
