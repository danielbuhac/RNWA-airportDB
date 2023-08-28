﻿using System;
using System.Collections.Generic;

#nullable disable

namespace REST_API.Models
{
    public partial class AirportReachable
    {
        public short AirportId { get; set; }
        public int? Hops { get; set; }

        public virtual Airport Airport { get; set; }
    }
}
