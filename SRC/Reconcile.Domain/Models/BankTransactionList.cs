using Reconcile.Domain.Consts;
using Reconcile.Domain.Extension_Methods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class BankTransactionList : BaseModel
    {
        #region Constructor

        public BankTransactionList(IEnumerable<string> tags) : base(tags, OFXTags.BankTransactionList)
        {
            STMTTRNS = new List<Transaction>();

            ContFrom = 0;

            _fillAction = (tagName, tagValue) =>
            {
                switch (tagName)
                {
                    case OFXTags.DTSTART:
                        DTSTART = tagValue.ToDatetime();
                        break;
                    case OFXTags.DTEND:
                        DTEND = tagValue.ToDatetime();
                        break;
                    case OFXTags.Transaction:
                        var tempTransaction = new Transaction(_chunkList);
                        STMTTRNS.Add(tempTransaction);
                        ContFrom += tempTransaction.ContFrom;
                        break;
                }
            };

            FillDTO();
        }

        #endregion

        #region Properties

        public DateTime DTSTART { get; set; }
        public DateTime DTEND { get; set; }
        public List<Transaction> STMTTRNS { get; set; }

        #endregion
    }
}
