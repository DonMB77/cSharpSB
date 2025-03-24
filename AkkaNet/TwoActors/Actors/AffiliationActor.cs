using Akka.Actor;
using cSharpSB.AkkaNet.TwoActors.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSB.AkkaNet.TwoActors.Actors
{
    class AffiliationActor : ReceiveActor
    {
        public AffiliationActor()
        {
            Receive<Transaction>(transaction =>
            {
                if ((transaction.AffiliationCode == "0101") || (transaction.AffiliationCode == "0202"))
                {
                    var authActor = Context.ActorOf(Props.Create(() => new AuthorizationActor()));

                    authActor.Tell(transaction);
                    authActor.GracefulStop(new TimeSpan(10000));
                }
            });
        }
    }
}
