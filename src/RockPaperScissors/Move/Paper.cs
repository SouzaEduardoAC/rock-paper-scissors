namespace RPS.Move
{
    public sealed class Paper : IMove
    {
        public bool WinAgainst(IMove move) => !move.GetType().IsEquivalentTo(typeof(Scissors));

        public override string ToString() => "P";
    }
}
