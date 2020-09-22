using MyMicroRabbit.Banking.Application.Dtos;
using MyMicroRabbit.Banking.Application.Interfaces;
using MyMicroRabbit.Banking.Domain.Commands;
using MyMicroRabbit.Banking.Domain.Interfaces;
using MyMicroRabbit.Banking.Domain.Models;
using MyMicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus )
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransferDto accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount);
            _bus.SendCommand(createTransferCommand);
           
        }
    }
}
