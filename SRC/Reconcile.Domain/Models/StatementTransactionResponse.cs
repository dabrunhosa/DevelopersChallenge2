using Reconcile.Domain.Consts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class StatementTransactionResponse : BaseModel
    {
        #region Constructor

        public StatementTransactionResponse(IEnumerable<string> tags) : base(tags, OFXTags.StatementTransactionResponse)
        {
            STATUS = new Status(_chunkList);
            STMTRS = new StatementResponse(_chunkList);
        }

        #endregion

        #region BaseModel Methods

        protected override void FillModel()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Properties

        public int TRNUID { get; set; }
        public Status STATUS { get; set; }
        public StatementResponse STMTRS { get; set; }

        #endregion
    }
}
