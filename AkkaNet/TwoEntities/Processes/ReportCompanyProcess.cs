using cSharpSB.AkkaNet.TwoEntities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSB.AkkaNet.TwoEntities.Processes
{
    public class ReportCompanyProcess
    {
        public void SendReport(Company company)
        {
            Console.WriteLine("Company report: ");
            Console.WriteLine("----------------------");
            Console.WriteLine($"TaxDocument: {company.TaxDocument}");
            Console.WriteLine($"Description: {company.Description}\n");
        }
    }
}
