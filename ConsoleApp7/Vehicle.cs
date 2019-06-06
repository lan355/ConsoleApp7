using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Vehicle: IFactory,IName
    {
        //private DateTime dateFactory;
        private string factory;
        private string name;

        //public DateTime DateFactory { get => dateFactory; set => dateFactory = value; }
        public string Factory { get => factory; set => factory = value; }
        public string Name { get => name; set => name = value; }

        public string Color { get; set; }
        public void Color2()
        {
            Color = "Черный";
            Console.WriteLine(Color);
        }
        public void Work()
        {
            Name = "Лада";
            Console.WriteLine(Name);
        }   
    }

    class Car : IType
    {
        private string type;
        public string Type { get => type; set => type = value; }

        public void Car2()
        {
            Type = "Хетчбек";
            Console.WriteLine(Type);
            
        }

        
    }

    class Train :IWagons
    {
        private int wagons;
        public int Wagons { get => wagons; set => wagons = value; }

        public void Number()
        {
            Console.WriteLine("Введите количество вагонов");
            Wagons = int.Parse(Console.ReadLine());
        }
    }

    class Express :ISpeed
    {
        private double speed;
        public double Speed { get => speed; set => speed = value; }

        public void Speed1()
        {
            
            Console.WriteLine("Введите скорость");
            Speed = double.Parse(Console.ReadLine());
        }
    }

}
