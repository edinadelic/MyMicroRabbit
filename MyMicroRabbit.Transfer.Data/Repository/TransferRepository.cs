using MyMicroRabbit.Transfer.Data.Context;
using MyMicroRabbit.Transfer.Domain.Interfaces;
using MyMicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyMicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;

        public TransferRepository(TransferDbContext context )
        {
            _context = context;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TransferLogs;
        }

        public void AddTransferLog(TransferLog transferLog)
        {
            _context.Add(transferLog);
            _context.SaveChanges();
        }
    }
}
