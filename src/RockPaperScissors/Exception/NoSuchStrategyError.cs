namespace RPS.Exception
{
    public class NoSuchStrategyError : System.Exception
    {
        public NoSuchStrategyError(string noSuchStrategy) : base(noSuchStrategy)
        {
            
        }
    }
}
