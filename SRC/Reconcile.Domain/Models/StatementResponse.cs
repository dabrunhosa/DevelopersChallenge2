using Reconcile.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class StatementResponse
    {
        public Currency CURDEF { get; set; }
        public BankAccount BANKACCTFROM { get; set; }
        public BankTransactionList BANKTRANLIST { get; set; }
        public LedgeBalance LEDGERBAL { get; set; }
    }
}
