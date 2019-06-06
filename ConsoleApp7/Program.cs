using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        struct Transport 
        {
            public string car;
            public string name;
            public string color;
            public int wagons;
            public double speed;
            
        }

        delegate void Method();

        static void Main(string[] args)
        {
            Method print;
            Car car = new Car();
            car.Car2();


            Vehicle vehicle = new Vehicle();
            vehicle.Color2();
            vehicle.Work();


            Train train = new Train();
            train.Number();

            Express express = new Express();
            express.Speed1();
        back:
            Console.Clear();
        
            int N = 1;

            Transport[] transport = new Transport[N];
            
            for (int i = 0; i < N; i++)
            {
                transport[i].car = car.Type;
                transport[i].name = vehicle.Name;
                transport[i].color = vehicle.Color;
                transport[i].wagons = train.Wagons;
                transport[i].speed = express.Speed;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("№ {0}\t{1}\t{2}\t{3}\t{4}\n", i + 1, transport[i].car, transport[i].name, transport[i].color, transport[i].wagons, transport[i].speed);
            }
            Console.ReadLine();

            int Select2;
            Console.WriteLine("1-Найти; 2 - Изменить; 3 - Выйти");
            Console.WriteLine("Выберите что хотите сделать");
            Select2 = int.Parse(Console.ReadLine());
            switch (Select2)
            {
                case 1:
                    Find();
                    break;
                case 2:
                    Change();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }

            Transport[] Change()
             {
                Console.Clear();
                int Select;
                Console.WriteLine("1 - Изменить тип авто; 2 - Изменить цвет авто; 3 - Изменить наименование авто; 4 - Изменить количество вагонов");
                Console.WriteLine("Выберите номер строки");
                int i = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Введите, что изменить");
                Select = int.Parse(Console.ReadLine());

                Console.WriteLine("№ {0}\t{1}\t{2}\t{3}\t{4}", i + 1, transport[i].car, transport[i].name, transport[i].color, transport[i].wagons, transport[i].speed);

                switch (Select)
                {
                    case 1:
                        Console.WriteLine("Введите новый тип авто");
                        transport[i].car = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите новый цвет авто");
                        transport[i].color = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Введите новое наименование авто");
                        transport[i].name = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Введите новое количество вагонов");
                        transport[i].wagons = int.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine("№ {0}\t{1}\t{2}\t{3}\t{4}",i + 1, transport[i].car, transport[i].name, transport[i].color, transport[i].wagons, transport[i].speed);
                Console.ReadLine();
                return transport;
            }
            
            Transport[] Find()
            {
            
                Console.Clear();
                int Select;
                Console.WriteLine("1 - Найти тип авто; 2 - Найти цвет авто; 3 - Найти наименование авто; 4 - Найти количество вагонов ");
                Console.WriteLine("Введите, что найти");
                Select = int.Parse(Console.ReadLine());
                switch (Select)
                {
                   
                    case 1:
                        string type;
                        Console.WriteLine("Введите тип авто");
                        type = Console.ReadLine();
                        for(int i = 0; i < N; i++)
                        {
                            if (transport[i].car == type)
                            {
                                Console.WriteLine("№ {0}\t{1}\t{2}\t{3}\t{4}", i + 1, transport[i].car, transport[i].name, transport[i].color, transport[i].wagons, transport[i].speed); 
                            }
                        }
                        break;
                    case 2:
                        string color;
                        Console.WriteLine("Введите цвет авто");
                        color = Console.ReadLine();
                        for(int i = 0; i < N; i++)
                        {
                            if (transport[i].color == color)
                            {
                                Console.WriteLine("№ {0}\t{1}\t{2}\t{3}\t{4}", i + 1, transport[i].car, transport[i].name, transport[i].color, transport[i].wagons, transport[i].speed);
                            }
                        }
                        break;
                    case 3:
                        string name;
                        Console.WriteLine("Введите наименование авто");
                        name = Console.ReadLine();
                        for(int i = 0; i < N; i++)
                        {
                            if (transport[i].name == name)
                            {
                                Console.WriteLine("№ {0}\t{1}\t{2}\t{3}\t{4}", i + 1, transport[i].car, transport[i].name, transport[i].color, transport[i].wagons, transport[i].speed);
                            }
                        }
                        break;
                    case 4:
                        int wagons;
                        Console.WriteLine("Введите количество вагонов");
                        wagons = int.Parse(Console.ReadLine());
                        for(int i = 0; i < N; i++)
                        {
                            if (transport[i].wagons == wagons)
                            {
                                Console.WriteLine("№ {0}\t{1}\t{2}\t{3}\t{4}", i + 1, transport[i].car, transport[i].name, transport[i].color, transport[i].wagons, transport[i].speed);
                            }
                        }
                        break;     
                }
                return transport;
                
            }
            goto back;
        }

    }
              
}
