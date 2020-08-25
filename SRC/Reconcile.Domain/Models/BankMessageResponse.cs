using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class BankMessageResponse : BaseModel
    {
        public StatementTransactionResponse STMTTRNRS { get; set; }
    }
}
