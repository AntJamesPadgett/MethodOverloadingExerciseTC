using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExerciseTC
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 29;
            var y = 55;

            var answer = Add(x, y);

            var a = 32.0m;
            var b = 45.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public static string Add(int number1, int number2, bool isCheck)
        {
            var sum = number1 + number2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
       
    }
}
