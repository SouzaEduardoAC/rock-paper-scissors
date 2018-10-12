using RPS.Move;

namespace RPS.Player
{
    public sealed class Player
    {
        private readonly string _name;
        private readonly IMove _move;

        public Player(string name, string move)
        {
            _name = name;
            _move = MoveFactory.GetMoveFor(move);
        }

        public IMove GetMove() => _move;

        public Player Versus(Player player)
        {
            var thisWinAgainstPlayer = _move.WinAgainst(player.GetMove());
            return thisWinAgainstPlayer ? this : player;
        }

        public override string ToString()
        {
            return $"[{_name}, {_move}]";
        }
    }
}
