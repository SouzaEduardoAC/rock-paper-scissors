using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RPS.Exception;

namespace RPS.Game
{
    public sealed class Tournament
    {
        public string Run()
        {
            var tournamentStarterGroup = CreateTournamentGroups();
            var winner = rps_tournament_winner(tournamentStarterGroup);
            return winner.ToString();
        }
        
        private Player.Player rps_tournament_winner(IEnumerable tournament)
        {
            var winners = (from List<Player.Player> match in tournament select rps_game_winner(match)).ToList();

            if (winners.Count > 1)
            {
                var newGroups = new ArrayList();
                for (var i = 0; i < winners.Count; i += 2)
                {
                    var newGroup = new List<Player.Player> { winners[i], winners[i + 1] };
                    newGroups.Add(newGroup);
                }
                return rps_tournament_winner(newGroups);
            } 

            return winners.First();
        }
        
        private static Player.Player rps_game_winner(IReadOnlyCollection<Player.Player> group)
        {
            if (!group.Count().Equals(2)) throw new WrongNumberOfPlayersError("There are not enough players in this group");
            return group.First().Versus(group.Last());
        }
        
        private ArrayList CreateTournamentGroups()
        {
            var arnando = new Player.Player("Arnando", "P");
            var dave = new Player.Player("Dave", "S");
            var firstMatch = CreateMatch(arnando, dave);

            var richard = new Player.Player("Richard", "R");
            var michael = new Player.Player("Michael", "S");
            var secondMatch = CreateMatch(richard, michael);

            var allen = new Player.Player("Allen", "S");
            var omer = new Player.Player("Omer", "P");
            var thirdMatch = CreateMatch(allen, omer);

            var david = new Player.Player("David E.", "R");
            var richardX = new Player.Player("Richard X.", "P");
            var fourthMatch = CreateMatch(david, richardX);

            var tournamentGames = new ArrayList { firstMatch, secondMatch, thirdMatch, fourthMatch };
            return tournamentGames;
        }

        private List<Player.Player> CreateMatch(Player.Player player1, Player.Player player2) => 
            new List<Player.Player> { player1, player2 };
        
    }
}
