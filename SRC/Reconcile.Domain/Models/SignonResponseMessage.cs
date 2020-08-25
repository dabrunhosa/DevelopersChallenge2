using Reconcile.Domain.Consts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class SignonResponseMessage : BaseModel
    {
        #region Constructor

        protected SignonResponseMessage(IEnumerable<string> tags, ref int contFrom) : base(tags, ref contFrom)
        {
            _tagName = OFXTags.SIGNONMSGSRSV1;
        }

        #endregion

        #region BaseModel Methods

        protected override void FillModel()
        {
            SONRS = new SignonResponse();
        }

        #endregion

        #region Properties

        public SignonResponse SONRS { get; set; }

        #endregion
    }
}
