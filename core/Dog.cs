using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye1.core
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public void Dogis()
        {
            Console.WriteLine($"{Name} играет в дотку лютейше.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Это Собака");
        }
    }
}
