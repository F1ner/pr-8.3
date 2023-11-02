using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_8._3
{
    internal class Program
    {
        //1 Написать метод рисующий на экране вертикальную линию из 30 символов *
        //static void Main()
        //{
        //    DrawLine(30);
        //    Console.ReadKey();
        //}
        //static void DrawLine(int Height)
        //{
        //    for(int i=0;i<Height;i++)
        //    {
        //        Console.WriteLine("*");
        //    }
        //    Console.WriteLine("");
        //}
        //2
        //static void Main()
        //{
        //    Console.Write("Введите высотку треугольника:");
        //    int height = int.Parse(Console.ReadLine());
        //    DrawTriangle(height);
        //    Console.ReadKey();
        //}
        //static void DrawTriangle(int height)
        //{
        //    int wid = height * 2 - 1;/*ширина строки*/
        //    for(int i=0;i<height;i++)
        //    {
        //        for(int j=0;j<i;j++)
        //        {
        //            Console.Write(" ");
        //        }
        //        for(int j=0;j<height-i;j++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();
        //    }

        //}
        ////3 Вычислить значение выражения определив и использовав дополнительный метод:
        //static void Main()
        //{
        //    double result = Calculate();
        //    Console.WriteLine("Результат выражения" + result);
        //    Console.ReadKey();
        //}
        //static double Calculate()
        //{
        //    double term1 = (1 + Math.Sin(1)) / 3.0;
        //    double term2 = (3 + Math.Sin(3)) / 3.0;
        //    double term3 = (5 + Math.Sin(5)) / 3.0;
        //    double result = term1 + term2 + term3;
        //    return result;
        //}
        //4 Найти наименьшее из 3 чисел:
        //public static void Main()
        //{
        //    Console.Write("a=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.Write("c=");
        //    int c = int.Parse(Console.ReadLine());
        //    int min = Min(Min(a, b), c);
        //    Console.WriteLine($"Наименьшее число-{min}");
        //    Console.ReadKey();
        //}
        //public static int Min(int a, int b)
        //{
        //    if (a < b)
        //        return a;
        //    else
        //        return b;
        //}
    }
}
