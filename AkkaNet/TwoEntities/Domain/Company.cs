using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSB.AkkaNet.TwoEntities.Domain
{
    public class Company
    {
        public string TaxDocument { get; private set; }
        public string Description { get; private set; }

        public Company(string taxDocument, string description)
        {
            TaxDocument = taxDocument;
            Description = description;
        }
    }
}
