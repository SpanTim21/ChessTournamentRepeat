using ChessTournamentRepeat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournamentRepeat.services
{
    internal interface IPlayerService
    {
        void Initialize();
        void Initialize(int[] idDetails, int[] rankingDetails, int[] nameDetails);

        List<Player> GeneratePlayers(int noOfPlayers);
    }
}
