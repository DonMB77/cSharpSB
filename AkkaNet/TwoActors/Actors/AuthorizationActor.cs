using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpSB.AkkaNet.TwoActors.Domain;
using cSharpSB.AkkaNet.TwoActors.ConsoleUtils;

namespace cSharpSB.AkkaNet.TwoActors.Actors
{
    public class AuthorizationActor : ReceiveActor
    {
        public AuthorizationActor()
        {
            Receive<Transaction>(transaction =>
            {
                if (((transaction.TransactionTypeEnum == Enums.TransactionTypeEnum.ECommerce) && (transaction.Amount < 100)) || ((transaction.TransactionTypeEnum != Enums.TransactionTypeEnum.ECommerce) && (transaction.Amount >= 10)))
                {
                    ConsoleUtil.PrintMsg("Authorization Response: OK = Success");
                }
                else
                {
                    ConsoleUtil.PrintMsg("Authorization Response: FAILED = Not authorized, invalid payment method", false);
                }
            });
        }
    }
}
