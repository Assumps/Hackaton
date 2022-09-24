using Core.EasyBusinessPay.Model;
using Core.EasyBusinessPay.Service;
using Core.EasyBusinessPay.ViewModel;
using Core.EasyBusinessPay.ViewModel.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.EasyBusinessPay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {   

        [HttpPost]
        public IActionResult Login([FromBody] RegisterViewModel register)
        {
            

            if (register.Email != "EasyPay@gmail.com" && register.Password != "teste1")
               return StatusCode(400, new ResultViewModel<string>("05X99 - Email ou senha Incorreto"));

            var accountlogin = new Account
            {
                Email = register.Email,
                Password = register.Password,
                Status = true
            };

            return Ok(accountlogin);

        }
    }
}
