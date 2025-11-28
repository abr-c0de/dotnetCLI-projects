using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurningObjects
{
    public class Corner : ITurnable
    {
        public string Turn()
        {
            return "Turn left in the corner";
        }
    }
}
