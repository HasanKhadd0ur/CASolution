using CASolution.Application.Contracts.Authorization;
using System.Collections.Generic;

namespace CASolution.Application.Contracts.Authentication
{
    public class AuthenticationResult
    {
        public int EmployeeId { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public ICollection<Role> Roles { get; set; }
        public string Token { get; set; }

    }


}
