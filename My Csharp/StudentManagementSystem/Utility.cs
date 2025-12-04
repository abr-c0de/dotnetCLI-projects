using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdManagementSys
{
    public static class Utility
    {
        public static int SId = 0;

        public static int CId = 99;

        public static int getStdId() => SId++;

        public static int getCrsId() => CId++;
    }
}
