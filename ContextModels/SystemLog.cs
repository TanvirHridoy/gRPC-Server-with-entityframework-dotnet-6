using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class SystemLog
    {
        public int Id { get; set; }
        public string? Operator { get; set; }
        public DateTime? LogTime { get; set; }
        public string? MachineAlias { get; set; }
        public short? LogTag { get; set; }
        public string? LogDescr { get; set; }
    }
}
