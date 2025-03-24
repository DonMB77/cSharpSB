using Akka.Actor;
using cSharpSB.AkkaNet.TwoActors.Actors;
using cSharpSB.AkkaNet.TwoActors.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSB.AkkaNet.TwoActors
{
    class Program
    {
        private static void Main(String[] args)
        {
            var system = ActorSystem.Create("TransactionSystem");
            var affilitionActor = system.ActorOf<AffiliationActor>(nameof(AffiliationActor));

            var transactionA = new Transaction(Enums.TransactionTypeEnum.ECommerce, 100.00, "0101");
            var transactionB = new Transaction(Enums.TransactionTypeEnum.TEF, 101.00, "0202");
            var transactionC = new Transaction(Enums.TransactionTypeEnum.POS, 97.00, "0303");

            affilitionActor.Tell(transactionA);
            affilitionActor.Tell(transactionB);
            affilitionActor.Tell(transactionC);

            Console.Read();
        }
    }
}
