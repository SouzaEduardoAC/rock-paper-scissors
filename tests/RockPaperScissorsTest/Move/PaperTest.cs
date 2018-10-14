using RPS.Move;
using Xunit;

namespace RockPaperScissorsTest.Move
{
    public class PaperTest
    {
        [Fact]
        public void Paper_ToString_Returns_P()
        {
            Assert.Equal("P", new Paper().ToString());
        }

        [Fact]
        public void Paper_Wins_Agains_Paper()
        {
            var paper = new Paper();
            Assert.True(paper.WinAgainst(new Paper()));
        }
        
        [Fact]
        public void Paper_Wins_Against_Rock()
        {
            var paper = new Paper();
            Assert.True(paper.WinAgainst(new Rock()));
        }

        [Fact]
        public void Paper_Loses_Agains_Scissors()
        {
            var paper = new Paper();
            Assert.False(paper.WinAgainst(new Scissors()));
        }
    }
}