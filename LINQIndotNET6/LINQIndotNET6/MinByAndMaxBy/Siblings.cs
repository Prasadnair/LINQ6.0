using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQIndotNET6.MinByAndMaxBy
{
    public class Siblings
    {
        public Siblings(string name, int age)        {
            Name = name;
            Age = age;
        }


        public string Name { get; set; }
        public int Age { get; set; }
    }
}
