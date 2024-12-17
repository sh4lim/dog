using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classnasledovaniye1.core
{
    internal class Car : Vehicle
    {
        public string bibika { get; set; }

        public void Vrum()
        {
            Console.WriteLine($"Моя крутая машина {Model} года {Year} с пробегом 160000 ваще норм только с завода вышла");
        }
        public override void GetInfo()
        {
            Console.WriteLine("Лада калина, не бита, не крашена, только с завода");
        }
    }
}
