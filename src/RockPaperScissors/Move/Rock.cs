namespace RPS.Move
{
    public sealed class Rock : IMove
    {
        public bool WinAgainst(IMove move) => !move.GetType().IsEquivalentTo(typeof(Paper));

        public override string ToString() => "R";
    }
}
