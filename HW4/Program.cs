using System;

namespace HW4Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Enter first number = ");
            // int a = int.Parse(Console.ReadLine());
            // Console.Write("Enter second number = ");
            // int b = int.Parse(Console.ReadLine());
            // int sum = 0;
            // for (int i = a + 1; i < b; i++)
            // {
            //     sum = sum + i;
            // }
            // Console.WriteLine($"Sum of numbers betwwen A and B is {sum}");
            // Console.Write("Enter first number = ");
            // int a = int.Parse(Console.ReadLine());
            // Console.Write("Enter second number = ");
            // int b = int.Parse(Console.ReadLine());
            // for (int i = a + 1; i < b; i++)
            // {
            //     if(i % 2 == 1)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            // Прямоугольник
            // for (int i = 0; i < 17; i++)
            // {
            //     Console.Write("-");
            // }
            // Console.WriteLine("");
            // for (int i = 0; i < 8; i++)
            // {
            //     Console.Write("|");
            //     for (int j = 0; j < 15; j++)
            //     {
            //         Console.Write(" ");
            //     }
            //     Console.WriteLine("|");
            // }
            // for (int i = 0; i < 17; i++)
            // {
            //     Console.Write("-");
            // }
            // Треугольник
            // for(int i = 1; i < 15; i++)
            // {
            //     Console.Write("|");
            //     for (int j = 0; j < i-1; j++)
            //     {
            //         Console.Write(" ");
            //     }
            //     Console.Write("\\");
            //     Console.WriteLine("");
            // }
            // for (int i = 0; i < 16; i++)
            // {
            //     Console.Write("-");
            // }
            // Ромб
            // No idea for ромб.
            // for(int a = 0; a < 15; a++)
            // {
            //     for (int i = 10; i > 0; i--)
            //     {                
            //         Console.Write(" ");
            //     }
            //     Console.Write("/");              
            //     Console.Write("\\");
            //     Console.WriteLine("");
            // }
            double initial = 1000;
            Console.Write("Enter percentage (0<p<25) = ");
            double p = double.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 0; i < 100; i++)
            {
                if(initial <= 1100){
                    initial = initial + (initial*p)/100;
                    k++;
                }
                else
                {
                    Console.WriteLine($"After {k} month it will exceed 1100");
                    break;
                }
            }
        }
    }
}
