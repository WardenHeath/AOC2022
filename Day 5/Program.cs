namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = System.IO.File.ReadAllText(@".\input.txt");

            string[] parts = lines.Split("\n\r");

            Console.WriteLine(parts[0]);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(parts[1]);
        }
    }
}