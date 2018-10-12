using RPS.Game;
using Xunit;

namespace RockPaperScissorsTest.Game
{
    public class TournamentTest
    {
        [Fact]
        public void Run_Tournamet()
        {
            Assert.Equal("[Richard, R]", new Tournament().Run());
        }
    }
}