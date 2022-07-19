using ChessTournamentRepeat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournamentRepeat.services
{
    internal class PlayerService : IPlayerService
    {
        private int _noOfPlayers;

        public PlayerService()
        {
           Initialize();
            GeneratePlayers();
        }

        public PlayerService(int noOfPlayers)
        {
            _noOfPlayers = noOfPlayers;
        }

        private LinkedList<Player> GeneratePlayers()
        {

        }
        public List<Player> GeneratePlayers(int noOfPlayers)
        {
            _noOfPlayers = noOfPlayers;
        }

        public void Initialize()
        {
            _noOfPlayers = 10;
        }

        public void Initialize(int[] idDetails, int[] rankingDetails, int[] nameDetails)
        {
            throw new NotImplementedException();
        }

        List<Player> IPlayerService.GeneratePlayers(int noOfPlayers)
        {
            throw new NotImplementedException();
        }

        List<Player> IPlayerService.GeneratePlayers(int noOfPlayers)
        {
            throw new NotImplementedException();
        }

        List<Player> IPlayerService.GeneratePlayers(int noOfPlayers)
        {
            throw new NotImplementedException();
        }

        List<Player> IPlayerService.GeneratePlayers(int noOfPlayers)
        {
            throw new NotImplementedException();
        }

        void IPlayerService.Initialize()
        {
            throw new NotImplementedException();
        }

        void IPlayerService.Initialize(int[] idDetails, int[] rankingDetails, int[] nameDetails)
        {
            throw new NotImplementedException();
        }
    }
}
