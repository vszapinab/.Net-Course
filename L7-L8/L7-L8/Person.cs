using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_L8
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;

            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
