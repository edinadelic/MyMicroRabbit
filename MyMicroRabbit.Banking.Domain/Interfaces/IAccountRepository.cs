using MyMicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMicroRabbit.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
       IEnumerable<Account> GetAccounts();
    }
}
