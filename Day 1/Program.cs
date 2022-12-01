namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@".\input.txt");
            List<int> elvesTotal = new List<int>();
            int total = 0;
            for(int i =0; i < lines.Length; i++){
               if(lines[i] == "" || lines[i] == string.Empty)
               {
                elvesTotal.Add(total);
                total = 0;
               }else{
                    total += int.Parse(lines[i]);
               } 
            }
            int sum = elvesTotal.Max();
            elvesTotal.Remove(elvesTotal.Max());
            sum += elvesTotal.Max();
            elvesTotal.Remove(elvesTotal.Max());
            sum += elvesTotal.Max();
            
            Console.WriteLine(String.Format("Highest Value: {0} \nSum of Top 3: {1}", elvesTotal.Max(),sum));
            Console.ReadLine();
        }
    }
}