using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classnasledovaniye1.core
{
    internal class Motorcycle : Vehicle
    {
        public string Motik { get; set; }

        public void Brum()
        {
            Console.WriteLine($"Опять это легендарный мотоцикл {Model} {Year} года выпуска ревет за окном ночью!");
        }
    }
}
