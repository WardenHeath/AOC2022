namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {

            //   COLUMN 1  | COLUMN 2
            // A = ROCK    | X = ROCK
            // B = PAPER   | Y = PAPER
            // C = SCISSORS| Z = SCISSORS
            //
            // COLUMN TWO IS MY CHOICE
            // VALUES FOR EACH CHOICE
            // CHOICE   | VALUE
            // ROCK     |   1  
            // PAPER    |   2
            // SCISSORS |   3
            // 6 FOR WIN
            // 0 FOR LOSS
            // 3 FOR DRAW
            // PART 2
            //   COLUMN 1  | COLUMN 2
            // A = ROCK    | X = lose
            // B = PAPER   | Y = draw
            // C = SCISSORS| Z = Win
            string[] lines = System.IO.File.ReadAllLines(@".\input.txt");
            List<int> POINTSTOTALPERLINE = new List<int>();
            List<int> POINTSTOTALPERLINEPART2 = new List<int>();
            int Total = 0;
            int TotalPart2 = 0;
            for(int i =0; i < lines.Length; i++){
                    POINTSTOTALPERLINE.Add(new int());
                    POINTSTOTALPERLINEPART2.Add(new int());
                    var elf = 0;
                    var me = 0;
                    switch(lines[i].Split(" ")[1]){
                        case "X":
                            POINTSTOTALPERLINE[i] = 1;
                            POINTSTOTALPERLINEPART2[i] = 0;
                            me = 2;
                            break;
                        case "Y":
                            POINTSTOTALPERLINE[i] = 2;
                            POINTSTOTALPERLINEPART2[i] = 3;
                            me = 0;
                            break;
                        case "Z":
                            POINTSTOTALPERLINE[i] = 3;
                            POINTSTOTALPERLINEPART2[i] = 6;
                            me = 1;
                            break;
                    }
                    switch(lines[i].Split(" ")[0]){
                        case "A": //rock = 1
                            elf = 2;
                            //Console.WriteLine(string.Format("Case A, Points2: {0}",POINTSTOTALPERLINEPART2[i]));
                            switch(POINTSTOTALPERLINEPART2[i]){
                                case 0: //loss = scissors
                                    POINTSTOTALPERLINEPART2[i] += 3;
                                    break;
                                case 3: // draw = rock
                                    POINTSTOTALPERLINEPART2[i] += 1;
                                    break;
                                case 6: // win = papar
                                    POINTSTOTALPERLINEPART2[i] += 2;
                                    break;
                            }
                            break;
                        case "B": // paper = 2
                            elf = 0;
                            switch(POINTSTOTALPERLINEPART2[i]){
                                case 0: //loss = rock
                                    POINTSTOTALPERLINEPART2[i] += 1;
                                    break;
                                case 3: // draw = paper
                                    POINTSTOTALPERLINEPART2[i] += 2;
                                    break;
                                case 6: // win = scissors
                                    POINTSTOTALPERLINEPART2[i] += 3;
                                    break;
                            }
                            break;
                        case "C": // scissors = 3
                            elf = 1;
                            switch(POINTSTOTALPERLINEPART2[i]){
                                case 0: //loss = rock
                                    POINTSTOTALPERLINEPART2[i] += 1;
                                    break;
                                case 3: // draw = scissors
                                    POINTSTOTALPERLINEPART2[i] += 3;
                                    break;
                                case 6: // win = paper
                                    POINTSTOTALPERLINEPART2[i] += 2;
                                    break;
                            }
                            break;
                    }

                    if(me != elf){
                        POINTSTOTALPERLINE[i] += elf == (me+1)%3 ? 0 : 6;
                    }else{
                        POINTSTOTALPERLINE[i] += 3;
                    } 
            }

            Total = POINTSTOTALPERLINE.Sum();
            TotalPart2 = POINTSTOTALPERLINEPART2.Sum();
            
            Console.WriteLine(String.Format("Points Total: {0}\nPoints Total part 2: {1}", Total, TotalPart2));
            Console.ReadLine();
        }
    }
}