using MyMicroRabbit.Domain.Core.Bus;
using MyMicroRabbit.Transfer.Application.Interfaces;
using MyMicroRabbit.Transfer.Domain.Interfaces;
using MyMicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
             _transferRepository = transferRepository;
            _bus = bus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
            
        }

    }
}
