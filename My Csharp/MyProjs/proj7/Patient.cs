using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj7
{
    public class Patient : IRecoverable
    {
        public string Recover()
        {
            return "Patient is recovering in the doctor's office";
        }
    }
}
