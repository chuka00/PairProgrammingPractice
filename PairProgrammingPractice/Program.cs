using static PairProgrammingPractice.MathematicalOperations;

namespace PairProgrammingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { -12, -5, -20, 32, 45, 10, 9};
            int[] myNum = { -15, -25, 41, -28 ,10, 20, 30, 40 };
            //MathematicalOperations.CheckNegativeIntergers(list);
            //MathematicalOperations.LambdaExpressionSyntax();

            IEnumerable<int> Square (IEnumerable<int> data)
            {
                var  results = data.Where(x => x > 0).ToList();
                Console.WriteLine(string.Join(", ", results));
                //Console.WriteLine($"The Sum of all the Squared positive numbers is: {sum}");
                return results;
            }

            Square(myNum);
            Square(list);
            //ArrayList.Square(list);
            //ArrayList.CollectList();
            //ArrayList.SettingDefaults();
            /*MathematicalOperations mathematicalOperations = new();
            mathematicalOperations.Square(list);*/


            /*for (int i = 0; i < 20; i++)
            {
                DoWhile();
            }*/







        }
    }
}