using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_L6.storage
{
    internal class MemoryStorage : IStorage
    {
        public void Save()
        {
            Console.WriteLine("Данные сохранены в память");
        }
    }
}
