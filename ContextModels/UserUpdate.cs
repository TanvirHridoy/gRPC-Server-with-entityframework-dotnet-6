using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class UserUpdate
    {
        public int UpdateId { get; set; }
        public string? BadgeNumber { get; set; }
    }
}
