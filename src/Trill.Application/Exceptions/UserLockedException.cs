using System;

namespace Trill.Application.Exceptions
{
    internal class UserLockedException : AppException
    {
        public Guid UserId { get; }

        public UserLockedException(Guid userId) : base($"User with ID: '{userId}' is locked.")
        {
            UserId = userId;
        }
    }
}