using Reconcile.Domain.Enum;
using System;

namespace Reconcile.Domain.Models
{
    public class SignonResponse
    {
        public Status STATUS { get; set; }
        public DateTime DTSERVER { get; set; }
        public LanguageType LANGUAGE { get; set; }
    }
}
