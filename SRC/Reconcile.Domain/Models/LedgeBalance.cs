using Reconcile.Domain.Consts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class LedgeBalance : BaseModel
    {
        #region Constructor

        public LedgeBalance(IEnumerable<string> tags) : base(tags, OFXTags.LedgeBalance)
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

        public double BALAMT { get; set; }
        public DateTime DTASOF { get; set; }

        #endregion
    }
}
