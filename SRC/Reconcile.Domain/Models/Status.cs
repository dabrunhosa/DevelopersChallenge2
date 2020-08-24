using Reconcile.Domain.Enum;

namespace Reconcile.Domain.Models
{
    public class Status
    {
        public int CODE { get; set; }
        public SeverityType SEVERITY { get; set; }
    }
}
