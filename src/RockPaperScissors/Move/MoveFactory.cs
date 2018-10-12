using RPS.Exception;

namespace RPS.Move
{
    public abstract class MoveFactory
    {
        public static IMove GetMoveFor(string move)
        {
            switch (move)
            {
                    case "S" : return new Scissors();
                    case "P" : return new Paper();
                    case "R" : return new Rock();
                    default: throw new NoSuchStrategyError("No such strategy");
            }
        }
    }
}
