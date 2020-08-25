using Reconcile.Domain.Consts;
using Reconcile.Domain.Extension_Methods;
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

        protected OFXFile(IQueryable<string> tags, ref int contFrom) : base(tags, ref contFrom)
        {
            _tagName = OFXTags.OFX;
        }

        #endregion

        #region BaseModel Methods
        
        protected override void FillModel()
        {
            SIGNONMSGSRSV1 = new SignonResponseMessage();
            BANKMSGSRSV1 = new BankMessageResponse();
        }

        #endregion

        #region Properties

        public SignonResponseMessage SIGNONMSGSRSV1 { get; set; }
        public BankMessageResponse BANKMSGSRSV1 { get; set; }

        #endregion
    }
}
