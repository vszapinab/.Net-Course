using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_L6
{
    internal class StepCounter
    {
        private int steps = 0;

        public void AddSteps(int count)
        {
            if (this.steps < 0) return;

            this.steps += count;
        }

        public void Reset()
        {
            this.steps = 0;
        }

        public int GetSteps() 
        { 
            return this.steps; 
        }
    }
}
