using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Models
{
    public class RequestReturnEntity : IRequestReturnEntity
    {
        public RequestReturnEntity(string message, int status)
        {
            Message = message;
            Status = status;
        }

        public int Status { get; set; }

        public string Message { get; set; }
    }
}
