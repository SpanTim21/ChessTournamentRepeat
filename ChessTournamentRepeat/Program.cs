using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournamentRepeat.Domain;
using ChessTournamentRepeat.services;

namespace ChessTournamentRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TournamentRepeat tournament = new TournamentRepeat();
            tournament.Start();

            Player p1 = CreateRandomPlayer();
            Console.WriteLine(p1);
          
        }

        public static Player CreateRandomPlayer()
        {
            return (new RandomPlayer());
            //return (new Player(CreateRandomNmuber(1,201), CreateRandomName(65, 91, 4), 
            //    CreateRandomNmuber(1000, 2001)));
        }

        public static int CreateRandomNumber(int min, int max)
        {
            int result = 0;
            Random rand = new Random();
            result = rand.Next(min, max);
            return (result);
        }

        public static string CreateRandomName(int min, int max, int noOfChars)
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < noOfChars; i++)
            {
                sb.Append((char)rand.Next(min, max));
            }
      
            result = sb.ToString(); 
            return (result);

        }
    }
}
