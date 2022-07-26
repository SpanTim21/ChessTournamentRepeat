﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournamentRepeat.Domain
{
    internal class RandomPlayer : Player
    {
        private int[] _idDetails;
        private int[] _rankingDetails;
        private int[] _nameDetails;


        public RandomPlayer()
        {
            _idDetails = new int[2];    
            _idDetails[0] = 1;
            _idDetails[1] = 201;
            this.Id = CreateRandomNumber(_idDetails[0], _idDetails[1]);

            _nameDetails = new int[3];
            _nameDetails[0] = 65;
            _nameDetails[1] = 91;
            _nameDetails[2] = 4;
            this.Name = CreateRandomName(_nameDetails[0], _nameDetails[1], _nameDetails[2]);

            _rankingDetails = new int[2];
            _rankingDetails[0] = 1000;
            _rankingDetails[1] = 2001;
            this.Ranking = CreateRandomNumber(_rankingDetails[0], _rankingDetails[1]);
        }

        public RandomPlayer(int[] idDetails, int[] rankingDetails, int[] nameDetails)
        {
            this._idDetails = idDetails;
            this._rankingDetails = rankingDetails;
            this._nameDetails = nameDetails;
            this.Id = CreateRandomNumber(_idDetails[0], _idDetails[1]);
            this.Name = CreateRandomName(_nameDetails[0], _nameDetails[1], _nameDetails[2]);
            this.Ranking = CreateRandomNumber(_rankingDetails[0], _rankingDetails[1]);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
                sb.Append("Player {Id: ").Append(Id).Append(" \tName: ").Append(Name).Append("\tRanking: ").Append(Ranking).Append(" }");
                return sb.ToString();
        }
        private int CreateRandomNumber(int min, int max)
        {
            int result = 0;
            Random rand = new Random();
            result = rand.Next(min, max);
            return (result);
        }

        private string CreateRandomName(int min, int max, int noOfChars)
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
