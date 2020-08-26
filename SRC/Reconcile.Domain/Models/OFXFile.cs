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
            SIGNONMSGSRSV1 = new SignonResponseMessage(_chunkList);
            BANKMSGSRSV1 = new BankMessageResponse(_chunkList);
        }

        #endregion

        #region BaseModel Methods
        
        protected override void FillModel()
        {
            //int ofxPosition = 0;

            //SIGNONMSGSRSV1 = new SignonResponseMessage(_chunkList);
            //BANKMSGSRSV1 = new BankMessageResponse(_chunkList);
        }

        #endregion

        #region Properties

        public SignonResponseMessage SIGNONMSGSRSV1 { get; set; }
        public BankMessageResponse BANKMSGSRSV1 { get; set; }

        #endregion
    }
}
