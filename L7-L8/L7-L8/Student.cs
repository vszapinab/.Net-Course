using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_L8
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Id = Guid.NewGuid();
            Name = name;
            Grade = grade;
        }
    }
}
