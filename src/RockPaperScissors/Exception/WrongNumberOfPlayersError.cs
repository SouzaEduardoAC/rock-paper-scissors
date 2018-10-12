namespace RPS.Exception
{
    public class WrongNumberOfPlayersError : System.Exception
    {
        public WrongNumberOfPlayersError(string message) : base(message) { }
    }
}
