namespace ErrorHandling.Domain.Exception
{
    public abstract class DomainException : System.Exception
    {
        protected DomainException(string message) : base(message)
        {

        }
    }

    public class DomainNotFoundException : DomainException
    {
        public DomainNotFoundException(string message) : base(message)
        {

        }
    }
    public class DomainValidationException : DomainException
    {
        public DomainValidationException(string message) : base(message)
        {

        }

    }

}
