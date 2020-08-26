using Reconcile.Domain.Consts;
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
        }

        #endregion

        #region BaseModels Methods

        protected override void FillModel()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Properties

        public DateTime DTSTART { get; set; }
        public DateTime DTEND { get; set; }
        public List<Transaction> STMTTRNS { get; set; }

        #endregion
    }
}
