namespace Nsdn.MathUtilities.Exception
{
    public class StopBeforeStartException : System.Exception
    {
        public StopBeforeStartException() { }
        public StopBeforeStartException(string message) : base(message) { }
        public StopBeforeStartException(string message, System.Exception inner) : base(message, inner) { }
    }
}