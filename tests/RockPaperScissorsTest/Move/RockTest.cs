using RPS.Move;
using Xunit;

namespace RockPaperScissorsTest.Move
{
    public class RockTest
    {
        [Fact]
        public void Rock_ToString_Returns_R()
        {
            Assert.Equal("R", new Rock().ToString());
        }

        [Fact]
        public void Rock_Wins_Agains_Scissors()
        {
            var rock = new Rock();
            Assert.True(rock.WinAgainst(new Scissors()));
        }
        
        [Fact]
        public void Rock_Wins_Against_Rock()
        {
            var rock = new Rock();
            Assert.True(rock.WinAgainst(new Rock()));
        }

        [Fact]
        public void Rock_Loses_Agains_Paper()
        {
            var rock = new Rock();
            Assert.False(rock.WinAgainst(new Paper()));
        }
    }
}