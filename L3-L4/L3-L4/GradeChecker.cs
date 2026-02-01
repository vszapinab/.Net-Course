using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_L4
{
    internal class GradeChecker
    {
        int numericValue;

        public GradeChecker(int numericValue) {
            this.numericValue = numericValue;
        }

        public bool IsPassed()
        {
            return this.numericValue >= 3;
        }

    }
}
