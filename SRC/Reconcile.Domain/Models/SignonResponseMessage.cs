using Reconcile.Domain.Consts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class SignonResponseMessage : BaseModel
    {
        #region Constructor

        public SignonResponseMessage(IEnumerable<string> tags) : base(tags, OFXTags.SignonResponseMessage)
        {
            SONRS = new SignonResponse(_chunkList);
        }

        #endregion

        #region BaseModel Methods

        protected override void FillModel()
        {
            //SONRS = new SignonResponse();
        }

        #endregion

        #region Properties

        public SignonResponse SONRS { get; set; }

        #endregion
    }
}
