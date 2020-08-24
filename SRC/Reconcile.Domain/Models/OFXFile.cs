using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Models
{
    public class OFXFile
    {
        public SignonResponseMessage SIGNONMSGSRSV1 { get; set; }
        public BankMessageResponse BANKMSGSRSV1 { get; set; }
    }
}
