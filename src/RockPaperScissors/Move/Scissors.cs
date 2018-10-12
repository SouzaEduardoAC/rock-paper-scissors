namespace RPS.Move
{
    public sealed class Scissors : IMove
    {
        public bool WinAgainst(IMove move) => !move.GetType().IsEquivalentTo(typeof(Rock));

        public override string ToString() => "S";
    }
}
