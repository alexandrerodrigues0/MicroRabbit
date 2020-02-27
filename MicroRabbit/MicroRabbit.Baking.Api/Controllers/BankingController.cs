using System.Collections.Generic;
using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Baking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Baking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }
    }
}