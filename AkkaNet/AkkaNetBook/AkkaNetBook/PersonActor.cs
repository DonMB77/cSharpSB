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
    class PersonActor : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            if (message is VocalGreeting)
            {
                message.
            }
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
