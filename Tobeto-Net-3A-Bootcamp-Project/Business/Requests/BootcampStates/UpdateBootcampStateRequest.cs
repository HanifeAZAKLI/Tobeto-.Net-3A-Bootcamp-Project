﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.BootcampStates
{
    public class UpdateBootcampStateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
