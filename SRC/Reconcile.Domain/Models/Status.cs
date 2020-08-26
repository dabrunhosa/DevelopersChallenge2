using Reconcile.Domain.Consts;
using Reconcile.Domain.Enum;

namespace Reconcile.Domain.Models
{
    public class Status : BaseModel
    {
        #region Constructor

        public Status(System.Collections.Generic.IEnumerable<string> tags) : base(tags, OFXTags.STATUS)
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

        public int CODE { get; set; }
        public SeverityType SEVERITY { get; set; }

        #endregion
    }
}
