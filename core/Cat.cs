using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye1.core
{
    internal class Cat : Animal
    {
        public string Kotik { get; set; }

        public void Meow()
        {
            Console.WriteLine($"{Name}: бу испуглался? не бойся я друк. Подойди ко мне сядь ко мне, что ты не хочешь почему боишься присесть на {Age} лет?");
        }
    }
}
