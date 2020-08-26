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
            ContFrom = 0;
            SONRS = new SignonResponse(_chunkList);
            ContFrom += SONRS.ContFrom;
        }

        #endregion

        #region Properties

        public SignonResponse SONRS { get; set; }

        #endregion
    }
}
