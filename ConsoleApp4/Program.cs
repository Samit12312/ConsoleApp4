using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Targil1()
        {
            Console.WriteLine("insert 2 numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int max = Math.Max(x, y);
            int min = Math.Min(y, x);
            Console.WriteLine($"min={min} ,max= {max} ");
        }

        static void Targil2()
        {
            Console.WriteLine("insert 3 numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int max = Math.Max(x, Math.Max(y, z));
            int min = Math.Max(x, Math.Min(y, z));

            Console.WriteLine($"max= {max}");
        }
        static void Targil3()
        {
            Console.WriteLine("insert 3 grades");

            int grade1 = int.Parse(Console.ReadLine());
            int grade2 = int.Parse(Console.ReadLine());
            int grade3 = int.Parse(Console.ReadLine());

            double sum = grade1 + grade2 + grade3;
            double averge = sum / 3;

            Console.WriteLine($"averge{averge}");

        }

        static void Targil4()
        {
            int num;

            Console.WriteLine("enter num");

            num = int.Parse(Console.ReadLine());

            int meot = num / 100;

            int asarot = num / 10 % 10;

            int ahadot = num % 10;
            Console.WriteLine("meot" + meot);
            Console.WriteLine("asarot" + asarot);
            Console.WriteLine("ahadot" + ahadot);

        }
        static void Targil5()
        {
            Console.WriteLine("inter num 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inter num2");
            int num2 = int.Parse(Console.ReadLine());


            double num3 = Math.Pow(num1, num2);
            Console.WriteLine("num" + num3);


            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("inter num 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inter num2");
            int num2 = int.Parse(Console.ReadLine());


            double num3 = Math.Pow(num1, num2);
            Console.WriteLine("num" + num3);


            Console.ReadLine();
        }
    }
}
