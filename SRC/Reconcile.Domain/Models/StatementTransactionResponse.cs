using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class StatementTransactionResponse
    {
        public int TRNUID { get; set; }
        public Status STATUS { get; set; }
        public StatementResponse STMTRS { get; set; }
    }
}
