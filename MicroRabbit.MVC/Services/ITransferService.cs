using MicroRabbit.MVC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public interface ITransferService
    {
        Task CreateTransfer(TransferDto transferDto);
    }
}
