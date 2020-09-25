using System;
using System.Collections.Generic;
using System.Text;

namespace MyMicroRabbit.Transfer.Application.Models
{
    public class TransferLogDto
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }

    }
}
