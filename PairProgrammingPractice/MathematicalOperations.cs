using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingPractice
{
    public static class MathematicalOperations
    {
        //static HashSet<int> generatedNumbers = new HashSet<int>();
        public static IEnumerable<int> Square(IEnumerable<int> data) 
        {
            var results = data.Where(x => x > 0).Select(x => x * x).ToList();
            var sum = 0;
            foreach (var i in results)
            {
                sum += i;
            }

            Console.WriteLine(string.Join(", ", results));
            Console.WriteLine($"The Sum of all the Squared positive numbers is: {sum}");
            return results;
        }

        public static IEnumerable<int> CheckNegativeIntergers(IEnumerable<int> data)
        {
            var results = data.Where(x => x > 0).ToList();
            var sum = 0;
            foreach(var i in results)
            {
                sum += 1;
            }
            Console.WriteLine(string.Join(", ", results));
            Console.WriteLine($"Count of Positive Numbers is: {sum}");
            return results;
        }

        public static void LambdaExpressionSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new[] { 1, 2, 44, 54, 30, 12, 98});

            List<int> evenNumbers = list.FindAll(x => ( x/2 ) == 0);
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine($"These are even nums: {evenNumber}");
            }
        }

        /* public static int GenerateNumber()
         {
             Random number = new Random();

             int result = number.Next(28);

             generatedNumbers.Add(result);

             return result;
         }

         public static int CrossCheck(int num)
         {

             if (generatedNumbers.Contains(num))
             {
                 int result = GenerateNumber();
                 CrossCheck(result);
             }

             return num;

         }

         public static void Display()
         {
             var result = GenerateNumber();
             int d = CrossCheck(result);
             Console.WriteLine(d);
         }
 */

        //Random Number Generator
       /* public static void DoWhile()
        {
            var rand = new Random();

            var listNumbers = new List<int>();
            var number = 0;

            do
            {
                number = rand.Next(1, 29);
            } while (listNumbers.Contains(number));
            listNumbers.Add(number);

            Console.WriteLine(number);
        }*/
                    
    }
}
