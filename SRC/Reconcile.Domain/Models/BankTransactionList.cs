using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class BankTransactionList
    {
        public DateTime DTSTART { get; set; }
        public DateTime DTEND { get; set; }
        public List<Transaction> STMTTRNS { get; set; }
    }
}
