﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye1.core
{
    internal class Animal
    {
    public string Name { get; set; }
    public int Age { get; set; }

        public Animal() { }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Это Животное");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, возраст: {Age}.");
        }
    }
}
