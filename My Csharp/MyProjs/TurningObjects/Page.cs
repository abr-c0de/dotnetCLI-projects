using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurningObjects
{
    public class Page : ITurnable
    {
        public string Turn()
        {
            return "Pages turned backward";
        }
    }
}
