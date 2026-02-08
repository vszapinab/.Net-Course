using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_L6.transport
{
    internal abstract class Transport
    {
        public int Speed { get; set; }
        public string Name { get; set; }

        public virtual void Move()
        {
            Console.WriteLine("Транспорт движется");
        }
    }
}
