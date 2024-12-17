using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye1.core
{
    internal class Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle() { }
        public Vehicle(string model, int year)
        {
            Model = model;
            Year = year;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine("Лада калина, не бита, не крашена, только с завода");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Модель: {Model}, год выпуска: {Year}.");
        }
    }
}

