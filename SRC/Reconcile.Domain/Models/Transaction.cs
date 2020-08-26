using Reconcile.Domain.Consts;
using Reconcile.Domain.Enum;
using System;

namespace Reconcile.Domain.Models
{
    public class Transaction : BaseModel
    {
        #region Constructor

        public Transaction(System.Collections.Generic.IEnumerable<string> tags) : base(tags, OFXTags.Transaction)
        {
        }

        #endregion

        #region BaseModels Methods

        protected override void FillModel()
        {
            throw new NotImplementedException();
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
