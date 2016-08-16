using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MileStone1
{
    using System.IO;
    public class Program
    {
        public static void Main(string[] args)
        {
            Regex place = new Regex(@"([K,Q,B,N,R,P])([l,d])([a-hA-H])([1-8])");
            Regex move = new Regex(@"([a-hA-H])([1-8])\s([a-hA-H])([1-8])");
            Regex moveTwice = new Regex(@"([a-hA-H])([1-8])\s([a-hA-H])([1-8])\s([a-hA-H])([1-8])\s([a-hA-H])([1-8])");
            string fileName = args[0];
            Match m;
            using (StreamReader r = new StreamReader(fileName))
            {
                string command;
                while((command = r.ReadLine()) != null)
                {
                    if (place.IsMatch(command))
                    {
                        m = place.Match(command);
                        Place(m);
                    }
                    else if (moveTwice.IsMatch(command))
                    {
                        m = moveTwice.Match(command);
                        MoveTwice(m);
                    }
                    else if (move.IsMatch(command))
                    {
                        m = move.Match(command);
                        Move(m);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: invalid command [" + command + "]");
                    }
                }
            }
            
        }

        public static void Move(Match input)
        {
            Console.WriteLine("Piece at " + input.Groups[1] + input.Groups[2] + " was moved to " + input.Groups[3] + input.Groups[4]);
        }

        public static void MoveTwice(Match input)
        {
            Console.WriteLine("King from " + input.Groups[1] + input.Groups[2] + " was moved to " + input.Groups[3] + input.Groups[4] + " which caused a king-side castle which moved Rook from " + input.Groups[5] + input.Groups[6] + " to " + input.Groups[7] + input.Groups[8]);
        }

        public static void Place(Match input)
        {
            char rankCh = input.Groups[1].Value.ElementAt(0);
            string RankWord = CheckRank(rankCh);
            char sideCh = input.Groups[2].Value.ElementAt(0);
            string sideWord = GetSide(sideCh);
            Console.WriteLine("Placed " + sideWord + " " + RankWord + " at " + input.Groups[3] + input.Groups[4]);
        }

        private static string CheckRank(char c)
        {
            string rankWord = null;
            switch (c)
            {
                case 'K':
                    rankWord = "King";
                    break;
                case 'Q':
                    rankWord = "Queen";
                    break;
                case 'B':
                    rankWord = "Bishop";
                    break;
                case 'N':
                    rankWord = "Knight";
                    break;
                case 'R':
                    rankWord = "Rook";
                    break;
                case 'P':
                    rankWord = "Pawn";
                    break;
            }

            return rankWord;
        }
        
        private static string GetSide(char c)
        {
            string side = null;
            switch (c)
            {
                case 'l':
                    side = "Light";
                    break;
                case 'd':
                    side = "Dark";
                    break;
            }
            return side;
        }
    }
}
