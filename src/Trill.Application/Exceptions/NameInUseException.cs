using Trill.Core.Exceptions;

namespace Trill.Application.Exceptions
{
    internal class NameInUseException : DomainException
    {
        public string Name { get; }

        public NameInUseException(string name) : base($"Name {name} is already in use.")
        {
            Name = name;
        }
    }
}