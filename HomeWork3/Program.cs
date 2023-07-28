using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstTask(args);
            //SecondTask(args);
            //ThirdTask(args);

        }

        static void FirstTask(string[] args)
        {
            /*Задача 19
            Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое == последнему, второе == предпоследнему).
            14212->нет
            12821->да
            23432->да*/

            Console.WriteLine("Введите пятизначное число: ");
            string num = (Console.ReadLine());
            if(num.Length == 5)
            {
                if (num[0] == num[4] && num[1] == num[3])
                {
                    Console.WriteLine($"Ваше число {num} является палиндромом ");
                }
                else
                {
                    Console.WriteLine($"Ваше число {num} не является палиндромом ");
                }
                
            }
            Console.ReadLine();
        }

        static void SecondTask(string[] args)
        {
            /* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
             A(3, 6, 8); B(2, 1, -7), -> 15.84
             A(7, -5, 0); B(1, -1, 9)-> 11.53*/

            Console.WriteLine("Введите первую координату x");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую координату y");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите первую координату x2");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую координату y2");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите первую координату z1");
            int z1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую координату z2");
            int z2 = int.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine($"{distance:f2}");

            Console.ReadKey();
        }
        static void ThirdTask(string[] args)
        {
            /* Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
             3-> 1, 8, 27
             5-> 1, 8, 27, 64, 125*/
            Console.Write("Введите N: ");

            int number = int.Parse(Console.ReadLine());

            int count = 1;

            Console.WriteLine($"Таблица кубов числа {number}");

            while (count <= number)
            {
                Console.Write($"{Math.Pow(count, 3)}  ");
                count++;
            }
            Console.ReadKey();
        }
    }
}
