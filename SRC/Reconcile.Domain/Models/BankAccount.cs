using Reconcile.Domain.Consts;
using Reconcile.Domain.Enum;

namespace Reconcile.Domain.Models
{
    public class BankAccount : BaseModel
    {
        #region Constructor

        public BankAccount(System.Collections.Generic.IEnumerable<string> tags) : base(tags, OFXTags.BankAccount)
        {
        }

        #endregion

        #region BaseModel Methods

        protected override void FillModel()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Properties

        public int BANKID { get; set; }
        public int ACCTID { get; set; }
        public AccountType ACCTTYPE { get; set; }

        #endregion
    }
}
