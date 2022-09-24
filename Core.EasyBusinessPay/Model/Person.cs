using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.EasyBusinessPay.Model
{
    public class Person
    {
        public string personalId { get; set; }
        public string customerId { get; set; }
        public string customerName { get; set; }
        public string organizationId { get; set; }
        public string organizationName { get; set; }
        public string StateRegistration { get; set; }
        public string organizationCnpj { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

    }
}
