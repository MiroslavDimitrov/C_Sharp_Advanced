using System.IO;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\miro\Desktop\Text files\NewTextDocument.txt"); 
            Console.WriteLine("The text from the file is: {0}", text);

            string[] lines = File.ReadAllLines(@"C:\Users\miro\Desktop\C_Sharp Advanced.txt");

            Console.WriteLine("Content of the text file is: ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
        }
    }
}