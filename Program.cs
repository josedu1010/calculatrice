using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            { 
            Console.WriteLine("enter number");
            int num1 = Convert.ToInt32(Console.ReadLine());
           
            


            Console.WriteLine("a ou + = addition");
            Console.WriteLine();

            Console.WriteLine("s ou - = soustraction");
            Console.WriteLine();

            Console.WriteLine("m ou * = multiplication");
                Console.WriteLine();

            Console.WriteLine("d ou / =division");
            Console.WriteLine();

           

            string operateur = Console.ReadLine();

            Console.WriteLine("enter number");
            int num2 = Convert.ToInt32(Console.ReadLine());

                switch (operateur)
                {
                    case "a":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "s":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "m":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "d":
                        Console.WriteLine(num1 / num2);
                        break;
                    case "/":
                        Console.WriteLine(num1 / num2);
                        break;
                    defaut: Console.WriteLine("veuillez ressayer");
                        break;
                } 
            }

            

            Console.ReadLine();





        }
    }
}
