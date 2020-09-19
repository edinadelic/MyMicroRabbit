using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMicroRabbit.Banking.Application.Interfaces;
using MyMicroRabbit.Banking.Application.Services;
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
    }
}
