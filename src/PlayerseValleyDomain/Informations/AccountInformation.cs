using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerseValleyDomain.Informations
{
    public class AccountInformation
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
