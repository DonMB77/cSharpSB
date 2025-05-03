using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Akka;
using Akka.Actor;
using AkkaNetBook;

namespace EntryMain
{
    class MainClass
    {
        private static int Main()
        {
            var actorSystem = ActorSystem.Create("MyActorSystem");
            var actorRef = actorSystem.ActorOf<PersonActor>("personActorA");
            var adress = actorSystem.ActorSelection("/user/personActorA");
            actorRef.Tell(new VocalGreeting("Hi"));
            Console.WriteLine("test");
            return 0;
        }
    }
}