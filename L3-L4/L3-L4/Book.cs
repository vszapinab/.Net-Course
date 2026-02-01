using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_L4
{
    internal class Book
    {
        public Book() { }

        public string Title {get; set;}
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public string GetInfo()
        {
            return $"{this.Title}, {this.Pages} стр. ({this.Author} {this.Year})";
        }
    }
}
