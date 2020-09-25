using MyMicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MyMicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void AddTransferLog(TransferLog transferLog);
    }
}
