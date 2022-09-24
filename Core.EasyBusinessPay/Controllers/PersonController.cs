using Core.EasyBusinessPay.Model;
using Core.EasyBusinessPay.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.EasyBusinessPay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        static readonly HttpClient client = new HttpClient();

        [HttpGet("v1/GetPersonInfo/")]
        public async Task<IActionResult> GetPersonInfo([FromHeader] string organizationid, [FromHeader] string customerid)
        {
            try
            {
                
                client.DefaultRequestHeaders.Add("organizationid", organizationid);
                client.DefaultRequestHeaders.Add("customerid", customerid);
                var response = await client.GetAsync("https://challenge.hackathonbtg.com/customers/v1/personal/identifications");
                var content = await response.Content.ReadAsStringAsync();

                return Ok(content);
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<Person>("05X01 - Falha interna no servidor"));
            }
        }

        [HttpGet("v1/GetAccountInfo/")]
        public async Task<IActionResult> GetAccountInfo([FromHeader] string organizationid, [FromHeader] string customerid)
        {
            try
            {

                client.DefaultRequestHeaders.Add("organizationid", organizationid);
                client.DefaultRequestHeaders.Add("customerid", customerid);
                var response = await client.GetAsync("https://challenge.hackathonbtg.com/customers/v1/personal/qualifications");
                var content = await response.Content.ReadAsStringAsync();

                return Ok(content);
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<Person>("05X02 - Falha interna no servidor"));
            }
        }

    }
}
