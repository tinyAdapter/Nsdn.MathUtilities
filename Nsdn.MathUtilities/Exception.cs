namespace Nsdn.MathUtilities.Exception
{
    public class StopBeforeStartException : System.Exception
    {
        public StopBeforeStartException() { }
        public StopBeforeStartException(string message) : base(message) { }
        public StopBeforeStartException(string message, System.Exception inner) : base(message, inner) { }
    }

    public class NotEnoughItemException : System.Exception
    {
        public NotEnoughItemException() { }
        public NotEnoughItemException(string message) : base(message) { }
        public NotEnoughItemException(string message, System.Exception inner) : base(message, inner) { }
    }
}