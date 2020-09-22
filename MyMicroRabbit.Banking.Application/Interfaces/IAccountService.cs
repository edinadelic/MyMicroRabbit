using MyMicroRabbit.Banking.Application.Services;
using MyMicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MyMicroRabbit.Banking.Application.Dtos;

namespace MyMicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransferDto accountTransfer);
    }
}
