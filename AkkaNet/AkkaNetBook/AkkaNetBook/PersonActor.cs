using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Akka;
using Akka.Actor;

namespace AkkaNetBook
{
    class PersonActor : ReceiveActor
    {
        private int _peopleMet = 0;
        public PersonActor()
        {
            Receive<VocalGreeting>(async x =>
            {
                _peopleMet++;
                Console.WriteLine("I've met {0} people today", _peopleMet);
            });

            Receive<Wave>(x =>
            {
                Context.Sender.Tell(new VocalGreeting("Hello"));
                Context.Sender.Tell(new Wave());
            });
        }
    }

    class Wave { }

    class VocalGreeting
    {
        private readonly string _greeting;

        public string Greeting { get { return _greeting; } }

        public VocalGreeting(string greeting)
        {
            _greeting = greeting;
        }
    }
}
