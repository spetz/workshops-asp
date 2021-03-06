using System;

namespace Trill.Application.DTO
{
    public class AuthDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public long Expires { get; set; }
    }
}