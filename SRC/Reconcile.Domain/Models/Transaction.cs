using Reconcile.Domain.Enum;
using System;

namespace Reconcile.Domain.Models
{
    public class Transaction
    {
        public TransactionType TRNTYPE { get; set; }
        public DateTime DTPOSTED { get; set; }
        public double TRNAMT { get; set; }
        public string MEMO { get; set; }
    }
}
