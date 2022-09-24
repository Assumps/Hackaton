using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.EasyBusinessPay.ViewModel.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
