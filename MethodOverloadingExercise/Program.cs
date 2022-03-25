using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(8, 2));
            Console.WriteLine(Add(8.4m, 9.8m));
            Console.WriteLine(Add(0, 1, true));
            Console.ReadKey();
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return (num1 + num2); 
        }
        public static string Add(int num1, int num2, bool IsTrue)
        {
          var sum = num1 + num2;
            if (IsTrue && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (IsTrue && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
