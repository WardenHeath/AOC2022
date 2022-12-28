namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = System.IO.File.ReadAllText(@".\input.txt");

            string[] parts = lines.Split("\n\r");

            List<char>[] Cols = new List<char>[9]{  
                        new List<char>(),
                        new List<char>(),
                        new List<char>(),
                        new List<char>(),
                        new List<char>(),
                        new List<char>(),
                        new List<char>(),
                        new List<char>(),
                        new List<char>()};
            char space = ' ';
            

            string[] part1lines = parts[0].Split("\r\n");

            foreach(var item in part1lines){
                if(item[1] == '1') break;
                if(item[1] != space) Cols[0].Add(item[1]);
                if(item[5] != space) Cols[1].Add(item[5]);
                if(item[9] != space) Cols[2].Add(item[9]);
                if(item[13] != space) Cols[3].Add(item[13]);
                if(item[17] != space) Cols[4].Add(item[17]);
                if(item[21] != space) Cols[5].Add(item[21]);
                if(item[25] != space) Cols[6].Add(item[25]);
                if(item[29] != space) Cols[7].Add(item[29]);
                if(item[33] != space) Cols[8].Add(item[33]);
                Console.WriteLine(item);
            }
            for(int i =0; i < Cols.Length;i++){
                Cols[i].Reverse();
            }
            Console.WriteLine("1:  " + string.Join(", ", Cols[0]));
            Console.WriteLine("2:  " + string.Join(", ", Cols[1]));
            Console.WriteLine("3:  " + string.Join(", ", Cols[2]));
            Console.WriteLine("4:  " + string.Join(", ", Cols[3]));
            Console.WriteLine("5:  " + string.Join(", ", Cols[4]));
            Console.WriteLine("6:  " + string.Join(", ", Cols[5]));
            Console.WriteLine("7:  " + string.Join(", ", Cols[6]));
            Console.WriteLine("8:  " + string.Join(", ", Cols[7]));
            Console.WriteLine("9:  " + string.Join(", ", Cols[8]));


        }
    }
}