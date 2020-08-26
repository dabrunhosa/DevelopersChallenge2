using Reconcile.Domain.Consts;
using Reconcile.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class StatementResponse : BaseModel
    {
        #region Constructor

        public StatementResponse(IEnumerable<string> tags) : base(tags, OFXTags.StatementResponse)
        {
            ContFrom = 0;

            _fillAction = (tagName, tagValue) =>
            {
                switch (tagName)
                {
                    case OFXTags.CURDEF:
                        CURDEF = (Currency)System.Enum.Parse(typeof(Currency ), tagValue);
                        break;
                    case OFXTags.BankAccount:
                        BANKACCTFROM = new BankAccount(_chunkList);
                        ContFrom += BANKACCTFROM.ContFrom;
                        break;
                    case OFXTags.BankTransactionList:
                        BANKTRANLIST = new BankTransactionList(_chunkList);
                        ContFrom += BANKTRANLIST.ContFrom;
                        break;
                    case OFXTags.LedgeBalance:
                        LEDGERBAL = new LedgeBalance(_chunkList);
                        ContFrom += LEDGERBAL.ContFrom;
                        break;
                }
            };

            FillDTO();
        }

        #endregion

        #region Properties

        public Currency CURDEF { get; set; }
        public BankAccount BANKACCTFROM { get; set; }
        public BankTransactionList BANKTRANLIST { get; set; }
        public LedgeBalance LEDGERBAL { get; set; }

        #endregion
    }
}
