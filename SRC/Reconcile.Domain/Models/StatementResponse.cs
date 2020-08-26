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
            BANKACCTFROM = new BankAccount(_chunkList);
            BANKTRANLIST = new BankTransactionList(_chunkList);
            LEDGERBAL = new LedgeBalance(_chunkList);
        }

        #endregion

        #region BaseModel Methods

        protected override void FillModel()
        {
            throw new NotImplementedException();
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
