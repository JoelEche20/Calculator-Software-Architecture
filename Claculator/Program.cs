using System;

namespace Claculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 0;string z;int x = 0;int y = 0;
            do
            {
                Console.Write("choose an operator:");Console.WriteLine("+");Console.WriteLine("-");Console.WriteLine("*"); Console.WriteLine("/");
                z = Console.ReadLine(); string o = Convert.ToString(z);
                if (w == 0){Console.WriteLine("enter a numbers"); Console.Write("first number :");
                    x = int.Parse(Console.ReadLine()); Console.WriteLine("second number: "); y = int.Parse(Console.ReadLine());}
                else
                {Console.WriteLine("enter number: "); y = int.Parse(Console.ReadLine());}
                switch (o)
                {
                    case "+":
                        Console.WriteLine("result:");w = x + y;Console.WriteLine("{0}",w);
                        break;

                    case "-":
                        Console.WriteLine("result:");w = x - y;Console.WriteLine("{0}",w);
                        break;
                    case "*":
                        Console.WriteLine("result:");w = x * y;Console.WriteLine("{0}",w);
                        break;
                    case "/":
                        Console.WriteLine("result:");w = x / y;Console.WriteLine("{0}",w);
                        break;

                }
                Console.Write("Do you want to continue? y/n: ");z = Console.ReadLine();
                x = w;
            } while (z == "y");
        }
    }
}
