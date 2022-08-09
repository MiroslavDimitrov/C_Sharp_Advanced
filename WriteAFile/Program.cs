using System.IO;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines =
            { 
                "first line --> Miroslav",
                "Second line --> Dimitrov",
                "Third line --> from Lovech"
            };

            string[] numbers =
            { 
                "2",
                "3",
                "4",
            };

            using (StreamWriter file = new StreamWriter(@"C:\Users\miro\Desktop\Text files\NewTextPartTwo.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Lovech"))
                    {
                        file.WriteLine("Lives in Sofia");
                    }
                }
            }

            //create a new file
            File.WriteAllLines(@"C:\Users\miro\Desktop\Text files\NewText.txt", numbers);
            //write in an existing file
            File.WriteAllLines(@"C:\Users\miro\Desktop\Text files\NewTextDocument.txt", lines);
        }
    }
}