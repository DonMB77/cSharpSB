using Akka.Actor;
using cSharpSB.AkkaNet.TwoEntities.Domain;
using cSharpSB.AkkaNet.TwoEntities.Processes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSB.AkkaNet.TwoEntities.Actors
{
    public class ReportActor : ReceiveActor
    {
        private ReportCompanyProcess _reportCompanyProcess = new ReportCompanyProcess();
        public ReportActor()
        {
            Receive<Person>(message =>
            {
                Console.WriteLine($"Person data: {JsonConvert.SerializeObject(message)}\n\n");
            });

            Receive<Company>(message =>
            {
                _reportCompanyProcess.SendReport(message);
            });
        }
    }
}
