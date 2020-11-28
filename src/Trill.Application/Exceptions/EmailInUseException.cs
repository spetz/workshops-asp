using Trill.Core.Exceptions;

namespace Trill.Application.Exceptions
{
    internal class EmailInUseException : DomainException
    {
        public string Email { get; }

        public EmailInUseException(string email) : base($"Email {email} is already in use.")
        {
            Email = email;
        }
    }
}