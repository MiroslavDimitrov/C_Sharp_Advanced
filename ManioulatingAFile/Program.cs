namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> results = new List<string>();
            string[] lines = File.ReadAllLines(@"C:\Users\miro\Desktop\Text files\input.txt");

            foreach (string line in lines)
            {
                if (line.Contains("split"))
                {
                    line.Split();
                    results.Add(line);
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\miro\Desktop\Text files\outout.txt"))
            {
                for (int i = 0; i < results.Count; i++)
                {
                    if (i == 3)
                    {
                        file.WriteLine(results[i]);
                    }
                }
            }
        }
    }
}