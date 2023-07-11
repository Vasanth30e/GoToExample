using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string userName;
            //Again:
            //Console.WriteLine("Enter User Name");
            //userName = Console.ReadLine();

            //if (userName.Length >= 6)
            //{
            //    Console.WriteLine("Welcome :\t" + userName);

            //}
            //else
            //{
            //    Console.WriteLine("Invalid User Name");
            //    goto Again;
            //}
            string myString = "Vasanth";
            StringBuilder stringBuilder = new StringBuilder("Welcome ");
            stringBuilder.Append("To C# ");

            stringBuilder.Append("I am String Builder");

            stringBuilder.Append("string: " + myString);

            Console.WriteLine(stringBuilder);

            Console.ReadKey();

        }
    }
}
