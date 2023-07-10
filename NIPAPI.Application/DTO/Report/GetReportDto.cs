using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPAPI.Application.DTO.Report
{
   public class GetReportDto
    {
        public string? AccountNumber { get; set; }

        public string? SessionId { get; set; }

        [Required]
        public string DatabaseName { get; set; }
        [Required]

        public string CollectionName { get; set; }

    }
}
