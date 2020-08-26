using Reconcile.Domain.Consts;
using Reconcile.Domain.Enum;
using Reconcile.Domain.Extension_Methods;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Reconcile.Domain.Models
{
    public class SignonResponse : BaseModel
    {
        #region Constructor
        
        public SignonResponse(IEnumerable<string> tags) : base(tags, OFXTags.SignonResponse)
        {
            ContFrom = 0;

            _fillAction = (tagName, tagValue) =>
            {
                switch (tagName)
                {
                    case OFXTags.STATUS:
                        STATUS = new Status(_chunkList);
                        ContFrom += STATUS.ContFrom;
                        break;
                    case OFXTags.DTSERVER:
                        DTSERVER = tagValue.ToDatetime();
                        break;
                    case OFXTags.LANGUAGE:
                        LANGUAGE = (LanguageType)System.Enum.Parse(typeof(LanguageType), tagValue);
                        break;
                }
            };

            FillDTO();
        }

        #endregion

        #region Properties

        public Status STATUS { get; set; }
        public DateTime DTSERVER { get; set; }
        public LanguageType LANGUAGE { get; set; }

        #endregion
    }
}
