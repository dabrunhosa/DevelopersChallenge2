using Reconcile.Domain.Consts;
using Reconcile.Domain.Enum;
using Reconcile.Domain.Extension_Methods;
using System;
using System.Collections.Generic;

namespace Reconcile.Domain.Models
{
    public class Transaction : BaseModel
    {
        #region Constructor

        public Transaction(IEnumerable<string> tags, int contFrom) : base(tags, OFXTags.Transaction, contFrom)
        {
            ContFrom = 0;

            _fillAction = (tagName, tagValue) =>
            {
                switch (tagName)
                {
                    case OFXTags.TRNTYPE:
                        TRNTYPE = (TransactionType)System.Enum.Parse(typeof(TransactionType), tagValue);
                        break;
                    case OFXTags.DTPOSTED:
                        DTPOSTED = tagValue.ToDatetime();
                        break;
                    case OFXTags.TRNAMT:
                        TRNAMT = Convert.ToDouble(tagValue);
                        break;
                    case OFXTags.MEMO:
                        MEMO = tagValue;
                        break;
                }
            };

            FillDTO();
        }

        #endregion

        #region Properties

        public TransactionType TRNTYPE { get; set; }
        public DateTime DTPOSTED { get; set; }
        public double TRNAMT { get; set; }
        public string MEMO { get; set; }

        #endregion
    }
}
