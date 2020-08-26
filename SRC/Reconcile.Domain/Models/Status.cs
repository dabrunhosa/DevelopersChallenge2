using Reconcile.Domain.Consts;
using Reconcile.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System;
using System.Runtime.CompilerServices;
using System.Net.Http.Headers;

namespace Reconcile.Domain.Models
{
    public class Status : BaseModel
    {
        #region Constructor

        public Status(IEnumerable<string> tags) : base(tags, OFXTags.STATUS)
        {
            ContFrom = 0;

            _fillAction = (tagName, tagValue) =>
            {
                switch (tagName)
                {
                    case OFXTags.CODE:
                        CODE = Convert.ToInt32(tagValue);
                        break;
                    case OFXTags.SEVERITY:
                        SEVERITY = (SeverityType)System.Enum.Parse(typeof(SeverityType), tagValue);
                        break;
                }
            };

            FillDTO();
        }

        #endregion

        #region Properties

        public int CODE { get; set; }
        public SeverityType SEVERITY { get; set; }

        #endregion
    }
}
