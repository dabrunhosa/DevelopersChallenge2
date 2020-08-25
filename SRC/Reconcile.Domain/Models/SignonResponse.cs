using Reconcile.Domain.Consts;
using Reconcile.Domain.Enum;
using System;
using System.Collections.Generic;

namespace Reconcile.Domain.Models
{
    public class SignonResponse : BaseModel
    {
        #region Constructor
        
        protected SignonResponse(IEnumerable<string> tags, ref int contFrom) : base(tags, ref contFrom)
        {
            _tagName = OFXTags.SignonResponse;
        }

        #endregion

        #region BaseModel Methods

        protected override void FillModel()
        {
            STATUS = new Status();
        }

        #endregion

        #region Properties

        public Status STATUS { get; set; }
        public DateTime DTSERVER { get; set; }
        public LanguageType LANGUAGE { get; set; }

        #endregion
    }
}
