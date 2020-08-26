using Reconcile.Domain.Consts;
using Reconcile.Domain.Enum;
using System;

namespace Reconcile.Domain.Models
{
    public class BankAccount : BaseModel
    {
        #region Constructor

        public BankAccount(System.Collections.Generic.IEnumerable<string> tags) : base(tags, OFXTags.BankAccount)
        {
            ContFrom = 0;

            _fillAction = (tagName, tagValue) =>
            {
                switch (tagName)
                {
                    case OFXTags.BANKID:
                        BANKID = Convert.ToInt32(tagValue);
                        break;
                    case OFXTags.ACCTID:
                        ACCTID = Convert.ToInt64(tagValue);
                        break;
                    case OFXTags.ACCTTYPE:
                        ACCTTYPE = (AccountType)System.Enum.Parse(typeof(AccountType), tagValue);
                        break;
                }
            };

            FillDTO();
        }

        #endregion

        #region Properties

        public int BANKID { get; set; }
        public long ACCTID { get; set; }
        public AccountType ACCTTYPE { get; set; }

        #endregion
    }
}
