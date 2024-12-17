using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classnasledovaniye1.core
{
    internal class Developer : Employee
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"{Name}, {Salary}");
        }
    }
}
