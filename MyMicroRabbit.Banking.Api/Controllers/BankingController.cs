using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyMicroRabbit.Banking.Application.Dtos;
using MyMicroRabbit.Banking.Application.Interfaces;
using MyMicroRabbit.Banking.Domain.Models;

namespace MyMicroRabbit.Banking.Api.Controllers
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
        //GET api/banking

        [HttpGet]
        public ActionResult<IEnumerable<Account>> GetAccounts()
        {
            var accounts = _accountService.GetAccounts();
            return Ok(accounts);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransferDto accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
