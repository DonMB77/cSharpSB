using cSharpSB.AkkaNet.TwoActors.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSB.AkkaNet.TwoActors.Domain
{
    public class Transaction
    {
        public Guid Id { get; private set; }
        public DateTime CreateDate { get; private set; }
        public TransactionTypeEnum TransactionTypeEnum { get; private set; }
        public double Amount { get; private set; }
        public String AffiliationCode { get; private set; }

        public Transaction(TransactionTypeEnum transactionTypeEnum, double amount, string affiliationCode)
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            TransactionTypeEnum = transactionTypeEnum;
            Amount = amount;
            AffiliationCode = affiliationCode;
        }
    }
}
