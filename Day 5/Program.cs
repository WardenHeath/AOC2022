namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = System.IO.File.ReadAllText(@".\input.txt");

            string[] parts = lines.Split("\n\r");

            List<string> col1,col2,col3,col4,col5,col6,col7,col8,col9;

            Console.WriteLine(parts[0]);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(parts[1]);

            string[] part1lines = parts[0].Split("\r\n");



        }
    }
}