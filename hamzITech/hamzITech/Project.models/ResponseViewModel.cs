
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.models
{
    public class ResponseViewModel
    {
        public object status;

        public HttpStatusCode Status { get; set; }
        public string Message { get; set; }
        public object obj { get; set; }
        public LogLevel LogLevel { get; set; }
       // public StreamContent Content { get; set; }
    }
}
