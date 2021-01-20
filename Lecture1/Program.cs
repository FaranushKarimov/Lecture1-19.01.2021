using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto Task6;
            /* int x = 10;
             int y;
             string s = "Hello";
             string e = "World";*/
            //  double
            //  string
            //  char
            //  bool
            // System.Console.WriteLine(s +  " " + e);
            // System.Console.WriteLine
            // Console.WriteLine(x + 5);

            // int z = 0;
            /* int x = 5;
             int y = 5;
             int z = 8;
             int outAmount = -7;
             string text = null;
             int? i = null;


             bool result1 = !(x == y);
             bool result2 = x < y;

             bool result3 = x > y;
             bool result4 = x >= y;

             bool result5 = x <= y;
             bool result6 = x < y;

             bool result7 = x != y;

             bool result8 = x > y || x > z;
             bool result9 = x > y | x > z;

             // || or |
             // && and &

             int amount = outAmount > 0 ? outAmount : 0;
             if (outAmount >= 0) {
                 amount = outAmount;
             }
             else if (outAmount == 99) {

             }
             else if (outAmount == 100) {
                 amount = 0;
             }
             Console.WriteLine($"Amount = {amount}");

             Console.WriteLine(result8);
             Console.WriteLine(result9);
             Console.ReadKey();*/
            // Задание 1
            Console.WriteLine("Задание 1");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a = " + a);
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b = " + b);
            if (a >= 0 & b >= 0)
            {
                double result = Math.Round(Math.Sqrt(a * b),2);
                Console.WriteLine("Result = " + result);
            } else
            {
                Console.WriteLine("Input positive values");
            }
            // Задание 2
            Console.WriteLine("Задание 2");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A = " + A);
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B = " + B);
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("C = " + C);
            double AC = Math.Round(Math.Abs(A - C),2);
            Console.WriteLine("AC = " + AC);
            double BC = Math.Round(Math.Abs(B - C),2);
            Console.WriteLine("BC = " + BC);
            double summary = AC + BC;
            Console.WriteLine("AC + BC = " + Math.Round(summary,2));
            // Задание 3
            Console.WriteLine("Задание 3");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"x1,y1 = {x1} {y1}");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"x2,y2 = {x2} {y2}");
            double result2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("result = " + Math.Round(result2,2));
            // Задание 4
            Console.WriteLine("Задание 4");
            int? number = Convert.ToInt32(Console.ReadLine());
           // int? checkNumber = number > 10 & number < 100 ? number : null;
            Console.WriteLine($"Число : {number}");
            if (number >= 10 & number < 100)
            {
                Console.WriteLine($"Результат : {number % 10}{number / 10}");
            } else
            {
                Console.WriteLine("Введите двухзначное число");
            }
            // Задание 5
            Console.WriteLine("Задание 5");
            int second = Convert.ToInt32(Console.ReadLine());
            int minute = second / 60;
            Console.WriteLine("N = " + second);
            Console.WriteLine("Результат: " + minute);
            // Задание 6
           // Task6:
            Console.WriteLine("Задание 6");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"K = {day}\nНомер дня недели = {day%7}");

            
        }
    }
}
