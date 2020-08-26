using Reconcile.Domain.Consts;
using Reconcile.Domain.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Reconcile.Domain.Models
{
    public class OFXFile : BaseModel
    {
        #region Constructor

        public OFXFile(IEnumerable<string> tags) : base(tags, OFXTags.OFX)
        {
            ContFrom = 0;

            _fillAction = (tagName, tagValue) =>
            {
                switch (tagName)
                {
                    case OFXTags.SignonResponseMessage:
                        SIGNONMSGSRSV1 = new SignonResponseMessage(_chunkList);
                        ContFrom += SIGNONMSGSRSV1.ContFrom;
                        break;
                    case OFXTags.BankMessageResponse:
                        BANKMSGSRSV1 = new BankMessageResponse(_chunkList);
                        ContFrom += BANKMSGSRSV1.ContFrom;
                        break;
                }
            };

            FillDTO();
        }

        #endregion

        #region Properties

        public SignonResponseMessage SIGNONMSGSRSV1 { get; set; }
        public BankMessageResponse BANKMSGSRSV1 { get; set; }

        #endregion
    }
}
