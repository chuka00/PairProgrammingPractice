namespace PairProgrammingPractice
{
    public static class ArrayList
    {
        public static void CollectList()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System hock 2" };

           /* IEnumerable<string> subset =
                currentVideoGames.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);*/
            
            IEnumerable<string> subset =
                from g in currentVideoGames
                where g.Contains(" ")
                orderby g
                select g;

            foreach (string s in subset)
            {
                Console.WriteLine(s);
            }
        }



      /*  public static void SettingDefaults()
        {
            int[] numbers = Array.Empty<int>();
            var query = from i in numbers where i > 100 select i;
            var number = query.FirstOrDefault(-1);
            Console.WriteLine(number);
            number = query.SingleOrDefault(-2);
            Console.WriteLine(number);
            number = query.LastOrDefault(-3);
            Console.WriteLine(number);
        }*/

        public static IEnumerable<int> Square(IEnumerable<int> data)
        {
            var results = data.Where(x => x > 0).Select(x => x * x).ToList();
            var sum = 0;
            foreach (var i in results)
            {
                sum += 1;
            }
            Console.WriteLine(string.Join(", ", results));
            Console.WriteLine($"The count of all the positive numbers are {sum} ");
            return results;
        }
    }
}
