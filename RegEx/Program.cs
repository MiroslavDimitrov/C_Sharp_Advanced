using System.Text.RegularExpressions;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathern = @"\d";
            Regex regex = new Regex(pathern);
            string text = "My name is Miroslav, and my number is 12345.";

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("{0} hits found:\n {1}", matches.Count, text);

            foreach (Match hit in matches)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
        }
    }
}