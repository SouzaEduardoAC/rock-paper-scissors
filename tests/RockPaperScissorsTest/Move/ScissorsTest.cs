using RPS.Move;
using Xunit;

namespace RockPaperScissorsTest.Move
{
    public class ScissorsTest
    {
        [Fact]
        public void Scissors_ToString_Returns_S()
        {
            Assert.Equal("S", new Scissors().ToString());
        }

        [Fact]
        public void Scissors_Wins_Agains_Scissors()
        {
            var scissors = new Scissors();
            Assert.Equal(true, scissors.WinAgainst(new Scissors()));
        }
        
        [Fact]
        public void Scissors_Wins_Against_Paper()
        {
            var scissors = new Scissors();
            Assert.Equal(true, scissors.WinAgainst(new Paper()));
        }

        [Fact]
        public void Scissors_Loses_Agains_Rock()
        {
            var scissors = new Scissors();
            Assert.Equal(false, scissors.WinAgainst(new Rock()));
        }
    }
}