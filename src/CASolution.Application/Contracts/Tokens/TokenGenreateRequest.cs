
using CASolution.Application.Contracts.Authorization;
using System.Collections.Generic;

namespace CASolution.Application.Contracts.Tokens
{
    public class TokenGenreateRequest
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HashedPassword { get; set; }
        public ICollection<Role> Roles { get; set; }


    }
}
