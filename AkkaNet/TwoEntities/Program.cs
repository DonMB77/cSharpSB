using Akka.Actor;
using cSharpSB.AkkaNet.TwoEntities.Actors;
using cSharpSB.AkkaNet.TwoEntities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSB.AkkaNet.TwoEntities
{
    class Program
    {
        static void Main(String[] args)
        {
            var system = ActorSystem.Create("ReportSystem");
            var reportActor = system.ActorOf<ReportActor>("greeter");

            reportActor.Tell(new Person("Joe Satriani", 38));
            reportActor.Tell(new Person("Steve Vai", 28));
            reportActor.Tell(new Company("68363562525", "Transportadora X"));
            reportActor.Tell(new Company("12341341334", "Transportadora W"));
            reportActor.Tell(new Company("56778746746", "Transportadora L"));
            reportActor.Tell(new Company("75794749467", "Transportadora Z"));

            Console.Read();
        }
    }
}
