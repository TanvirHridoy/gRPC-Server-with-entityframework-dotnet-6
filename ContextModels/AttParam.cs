using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class AttParam
    {
        public string Paraname { get; set; } = null!;
        public string? Paratype { get; set; }
        public string Paravalue { get; set; } = null!;
    }
}
