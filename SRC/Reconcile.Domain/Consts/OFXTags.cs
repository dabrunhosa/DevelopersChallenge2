using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Consts
{
    public static class OFXTags
    {
        public const string OFX = "OFX";
        public const string SignonResponseMessage = "SIGNONMSGSRSV1";
        public const string SignonResponse = "SONRS";
        public const string STATUS = "STATUS"; 
        public const string CODE = "CODE";
        public const string SEVERITY = "SEVERITY"; 
        public const string DTSERVER = "DTSERVER"; 
        public const string LANGUAGE = "LANGUAGE"; 
        public const string BankMessageResponse = "BANKMSGSRSV1";
        public const string StatementTransactionResponse = "STMTTRNRS";
        public const string TRNUID = "TRNUID"; 
        public const string StatementResponse = "STMTRS";
        public const string CURDEF = "CURDEF";
        public const string BankAccount = "BANKACCTFROM";
        public const string BANKID = "BANKID";
        public const string ACCTID = "ACCTID";
        public const string ACCTTYPE = "ACCTTYPE";
        public const string BankTransactionList = "BANKTRANLIST";
        public const string DTSTART = "DTSTART";
        public const string DTEND = "DTEND";
        public const string Transaction = "STMTTRN";
        public const string TRNTYPE = "TRNTYPE";
        public const string DTPOSTED = "DTPOSTED";
        public const string TRNAMT = "TRNAMT";
        public const string MEMO = "MEMO";
        public const string LedgeBalance = "LEDGERBAL";
        public const string BALAMT = "BALAMT";
        public const string DTASOF = "DTASOF";
    }
}