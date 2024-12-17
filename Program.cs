using classnasledovaniye1.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Dog dog = new Dog();
            dog.Name = "Бубба";
            dog.Age = 6;

            dog.DisplayInfo();
            dog.Dogis();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.Name = "Мурзилка";
            cat.Age = 8;

            cat.DisplayInfo();
            cat.Meow();

            Car car = new Car();
            car.Model = "Лада калина";
            car.Year = 1995;

            car.DisplayInfo();
            car.Vrum();
            car.GetInfo();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Model = "Чайка 228";
            motorcycle.Year = 1986;

            motorcycle.DisplayInfo();
            motorcycle.Brum();

            Circle circle = new Circle();
            circle.CalculateArea();

            Rectangle rectangle = new Rectangle();
            rectangle.CalculateArea();

            Employee employee = new Employee("ААВАВВАВА", 15000);
            Manager manager = new Manager();
            manager.DisplayInfo();

            Developer developer = new Developer();
            developer.DisplayInfo();

        }

    }
}
