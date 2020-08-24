using Reconcile.Domain.Enum;

namespace Reconcile.Domain.Models
{
    public class BankAccount
    {
        public int BANKID { get; set; }
        public int ACCTID { get; set; }
        public AccountType ACCTTYPE { get; set; }
    }
}
