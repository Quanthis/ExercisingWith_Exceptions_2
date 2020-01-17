using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            do
            {
                try
                {
                    Console.Write("a= ");
                    a = Convert.ToDouble(Console.ReadLine());
                    if  (a <= 0) {Console.WriteLine("Side must be greater than 0.");
                        continue; }
                
                    b = a * a;
                    c = 4 * a;
                    Console.WriteLine("Area is equal to {0}, perimeter is equal to {1}", b, c);
                break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Incorrect input data format");
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Error message: {0}", ex.Message);
                }
            } while (1 == 1);
            Console.ReadKey();
        }
    }
}
