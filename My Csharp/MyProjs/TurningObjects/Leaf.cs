using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurningObjects
{
    public class Leaf : ITurnable
    {
        public string Turn()
        {
            return "The leaf Turned Upside down on the ground";
        }
    }
}
