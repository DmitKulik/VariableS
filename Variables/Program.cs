﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VariableS{
    internal class Program{
        static void Main(){


            /*string _myName = "Dima";
            int _age = 10; //лучше byte
            bool _pet = true;
            double _size = 39.5;
            string _favcolor = "Green";
            */

            // Console.WriteLine("Прочитать строку");
            //string _str = Console.ReadLine();

            //Финальная практика модуля «Анкетируем пользователей»
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.Write("You favorite day of week: ");
            var day = (Week) int.Parse(Console.ReadLine());
            Console.Write("Enter your birthdate: ");
            var birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} Age is {1} Favorite day is {2} and birthdate {3}", name, age, day, birthdate);
            Console.ReadKey();


            // Console.WriteLine("Имя {0},\nВозраст {1}\nЛюбимый цвет {2}", _myName, _age, _favcolor);

            /*Console.WriteLine($"My name is {_myName}");
            Console.WriteLine($"Мой возраст {_age}");
            Console.WriteLine($"Do i have a Pet? {_pet}");
            Console.WriteLine($"My shoe size is {_size}");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("floatMin {0} ", float.MinValue);
            Console.WriteLine("floatMax {0} ", float.MaxValue);
            */


           // double result3 = 10 % 3;
           //Console.WriteLine(result3);

           // Console.ReadKey();
          

        }


        enum Week : int
        {
            Tuesday = 100,
            Monday = 200,
            Wednesday = 300

        }




    }
}
