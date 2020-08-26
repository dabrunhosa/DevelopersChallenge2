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
            ContFrom = 0;
            _fillAction = (tagName, tagValue) =>
            {
                switch (tagName)
                {
                    case OFXTags.TRNUID:
                        TRNUID = Convert.ToInt32(tagValue);
                        break;
                    case OFXTags.STATUS:
                        STATUS = new Status(_chunkList);
                        ContFrom += STATUS.ContFrom;
                        break;
                    case OFXTags.StatementResponse:
                        STMTRS = new StatementResponse(_chunkList);
                        ContFrom += STMTRS.ContFrom;
                        break;
                }
            };

            FillDTO();
        }

        #endregion

        #region Properties

        public int TRNUID { get; set; }
        public Status STATUS { get; set; }
        public StatementResponse STMTRS { get; set; }

        #endregion
    }
}
