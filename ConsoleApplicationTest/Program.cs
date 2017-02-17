using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
   public class Program
    {
        public static void Main(string[] args)
        {
            localhost.WebServiceTest objet = new localhost.WebServiceTest(); 
            Console.WriteLine("\n Enter the number n to get the fibonacci number at the nth position:  ");
            int fibo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n " + objet.Fibonacci(fibo));
            Console.ReadKey();
        }
        
        
    }
}
