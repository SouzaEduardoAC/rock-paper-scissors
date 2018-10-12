using Xunit;
using RPS.Player;
using RPS.Move;

namespace RockPaperScissorsTest.Player
{
    public class PlayerTest
    {
        [Fact]
        public void Player_ToString_Returns_NameAndMove()
        {
            var player = new RPS.Player.Player("PlayerName", "S");
            Assert.Equal("[PlayerName, S]", player.ToString());
        }

        [Fact]
        public void Player_Move_Is_Rock()
        {
            var player = new RPS.Player.Player("Player", "R");
            Assert.IsType(typeof(Rock), player.GetMove());
        }

        [Fact]
        public void PlayerRockMove_Wins_Agains_PlayerScissors()
        {
            var playerRockMove = new RPS.Player.Player("John", "R");
            var playerScissorsMove = new RPS.Player.Player("Rob", "S");

            Assert.Equal(playerRockMove, playerRockMove.Versus(playerScissorsMove));
        }

        [Fact]
        public void PlayerRockMove_Wins_Agains_SameMove()
        {
            var playerOneRockMove = new RPS.Player.Player("First Rock Move", "R");
            var playerTwoRockMove = new RPS.Player.Player("Second Rock Move", "R");
            Assert.Equal(playerOneRockMove, playerOneRockMove.Versus(playerTwoRockMove));
        }

        [Fact]
        public void PlayerTwo_Wins_Agains_PlayerOne()
        {
            var playerOne = new RPS.Player.Player("Loser", "S");
            var playerTwo = new RPS.Player.Player("Winner", "R");
            Assert.Equal(playerTwo, playerOne.Versus(playerTwo));
        }
    }
}
