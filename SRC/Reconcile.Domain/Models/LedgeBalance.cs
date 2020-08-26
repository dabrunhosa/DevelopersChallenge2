using Reconcile.Domain.Consts;
using Reconcile.Domain.Extension_Methods;
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
            ContFrom = 0;

            _fillAction = (tagName, tagValue) =>
            {
                switch (tagName)
                {
                    case OFXTags.BALAMT:
                        BALAMT = Convert.ToDouble(tagValue);
                        break;
                    case OFXTags.DTASOF:
                        DTASOF = tagValue.ToDatetime();
                        break;
                }
            };

            FillDTO();
        }

        #endregion

        #region Properties

        public double BALAMT { get; set; }
        public DateTime DTASOF { get; set; }

        #endregion
    }
}
