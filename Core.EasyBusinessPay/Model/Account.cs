using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.EasyBusinessPay.Model
{
    public class Account
    {

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Status { get; set; } = false;
    }
}
