using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_L6.transport
{
    internal class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine($"Машина едет со скоростью {this.Speed}");
        }
    }
}
