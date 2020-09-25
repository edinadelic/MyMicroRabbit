using Microsoft.EntityFrameworkCore;
using MyMicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
