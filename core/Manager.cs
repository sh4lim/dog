using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye1.core
{
    internal class Manager : Employee
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"{Name}, {Salary}");
        }
    }
}
