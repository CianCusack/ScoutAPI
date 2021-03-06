﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoutAPI.Models
{
    public interface IRequestReturnEntity : IReturnEntity
    {
        int Status { get; set; }

        string Message { get; set; }
    }
}
