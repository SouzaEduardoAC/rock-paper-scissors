using System;
using RPS.Exception;
using RPS.Move;
using Xunit;

namespace DefaultNamespace
{
    public class MoveFactoryTest
    {
        [Fact]
        public void Factory_Returns_Rock()
        {
            var move = "R";
            var moveReturned = MoveFactory.GetMoveFor(move);
            Assert.IsType(typeof(Rock), moveReturned);
        }

        [Fact]
        public void FactoryReturnsPaper()
        {
            var move = "P";
            var moveReturned = MoveFactory.GetMoveFor(move);
            Assert.IsType(typeof(Paper), moveReturned);
        }

        [Fact]
        public void Factory_Returns_Scissors() 
        {
            var move = "S";
            var moveReturned = MoveFactory.GetMoveFor(move);
            Assert.IsType(typeof(Scissors), moveReturned);
        }

        [Fact]
        public void Factory_Throws_NoSuchStrategyError() 
        {
            var move = "T";
            Assert.Throws<NoSuchStrategyError>(() => MoveFactory.GetMoveFor(move));
        }
    }
}