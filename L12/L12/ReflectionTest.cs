using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12
{
    public class ReflectionTest
    {
        public static void PrintProperties(object obj)
        {
            Type type = obj.GetType();
            Console.WriteLine($"Имя: {type.Name}");
            var props = type.GetProperties();
            foreach (var item in props)
            {
                var value = item.GetValue(obj);
                Console.WriteLine($"{item.Name}: {value}");
            }
        }
    }
}
