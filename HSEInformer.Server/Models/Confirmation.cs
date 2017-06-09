﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSEInformer.Server.Models
{
    public class Confirmation
    {
        public int Id { get; set; }

        public HSEMember Member { get; set; }

        public string Code { get; set; }
    }
}
