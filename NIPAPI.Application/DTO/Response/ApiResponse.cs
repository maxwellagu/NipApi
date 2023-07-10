using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPAPI.Application.DTO.Response
{
    public class ApiResponse
    {
        public string ResponseCode { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}
