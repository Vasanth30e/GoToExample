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
            //string myString = "Vasanth";
            //StringBuilder stringBuilder = new StringBuilder("Welcome ");
            //stringBuilder.Append("To C# ");

            //stringBuilder.Append("I am String Builder");

            //stringBuilder.Append("string: " + myString);

            //Console.WriteLine(stringBuilder);

            DateTime matchDate = new DateTime(day: 12, month: 08, year: 2025);
            DateTime currentDate = DateTime.Now;
            TimeSpan ts = matchDate.Subtract(currentDate);
            Console.WriteLine("Days Remain" +ts.Days);
            Console.WriteLine("Days Remain" + ts.Hours);
            Console.WriteLine(ts.ToString());


            Console.ReadKey();





        }
    }
}
