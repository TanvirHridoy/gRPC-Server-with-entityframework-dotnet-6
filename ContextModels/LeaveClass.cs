using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class LeaveClass
    {
        public int LeaveId { get; set; }
        public string LeaveName { get; set; } = null!;
        public double MinUnit { get; set; }
        public short Unit { get; set; }
        public short RemaindProc { get; set; }
        public short RemaindCount { get; set; }
        public string ReportSymbol { get; set; } = null!;
        public double Deduct { get; set; }
        public int Color { get; set; }
        public short? Classify { get; set; }
    }
}
