namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@".\input.txt");
            int count = 0;
            int Part2Conunt = 0;
            foreach(var item in lines){
                string LeftSide = item.Split(",")[0];
                string RightSide = item.Split(",")[1];

                int leftSideStart = int.Parse(LeftSide.Split("-")[0]);
                int leftSideEnd = int.Parse(LeftSide.Split("-")[1]);
                
                int rightSideStart = int.Parse(RightSide.Split("-")[0]);
                int rightSideEnd = int.Parse(RightSide.Split("-")[1]);
                // Console.WriteLine(string.Format("Full string: {0},\nLeftSide: {1};{2}\nRightside: {3};{4}",
                //                     item,
                //                     leftSideStart,
                //                     leftSideEnd,
                //                     rightSideStart,
                //                     rightSideEnd));

                if((leftSideStart <= rightSideStart && leftSideEnd >= rightSideEnd)||
                    (rightSideStart <= leftSideStart && rightSideEnd >= leftSideEnd))
                    count++;
                if( (leftSideStart <= rightSideStart && leftSideEnd >= rightSideEnd)||
                    (rightSideStart <= leftSideStart && rightSideEnd >= leftSideEnd)||
                    (FindOverlapping(leftSideStart,leftSideEnd,rightSideStart,rightSideEnd) > 0 )) Part2Conunt++;
                

            }
            int FindOverlapping (int start1, int end1, int start2, int end2)
                {
                    return Math.Max (0, Math.Min (end1, end2) - Math.Max (start1, start2) + 1);
                }
            Console.WriteLine(string.Format("Part one: {0}\nPart two: {1}", count,Part2Conunt));
        }   
    }
}