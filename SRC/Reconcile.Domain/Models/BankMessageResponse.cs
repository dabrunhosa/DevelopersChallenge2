using Reconcile.Domain.Consts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class BankMessageResponse : BaseModel
    {
        #region Constructor

        public BankMessageResponse(IEnumerable<string> tags) : base(tags, OFXTags.BankMessageResponse)
        {
            STMTTRNRS = new StatementTransactionResponse(_chunkList);
        }

        #endregion

        #region Properties

        public StatementTransactionResponse STMTTRNRS { get; set; }

        #endregion
    }
}
