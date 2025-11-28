using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurningObjects
{
    public class Pancake : ITurnable
    {
        public string Turn()
        {
            return "The pancake turned upside down on the pan";
        }
    }
}

