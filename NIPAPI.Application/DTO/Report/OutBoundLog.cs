using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPAPI.Application.DTO.Report
{
    public class OutBoundLog
    {
        public int Id { get; set; }
        public string _Id { get { return Id.ToString(); } }
        public string InstitutionId { get; set; }
        public string RequestSystem { get; set; }
        public string APICalled { get; set; }
        public string APIMethod { get; set; }
        public DateTime LogDate { get; set; }

        public string ImpactUniqueIdentifier { get; set; }
        public string ImpactUniqueidentifierValue { get; set; }

        public string AlternateUniqueidentifierValue { get; set; }
        public string AlternateUniqueIdentifier { get; set; }
        public string RequestDetails { get; set; }
        public DateTime RequestDateTime { get; set; }
        public string ResponseDetails { get; set; }
        public DateTime ResponseDateTime { get; set; }
        public List<LogDetails> OutboundLogs { get; set; }
        public string SystemCalledName { get; set; }
        public object? ExceptionDetails { get; set; }

    }


}
    
