using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class SchClass
    {
        public int SchClassid { get; set; }
        public string SchName { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? LateMinutes { get; set; }
        public int? EarlyMinutes { get; set; }
        public int? CheckIn { get; set; }
        public int? CheckOut { get; set; }
        public int? Color { get; set; }
        public short? AutoBind { get; set; }
        public DateTime? CheckInTime1 { get; set; }
        public DateTime? CheckInTime2 { get; set; }
        public DateTime? CheckOutTime1 { get; set; }
        public DateTime? CheckOutTime2 { get; set; }
        public double? WorkDay { get; set; }
        public string? SensorId { get; set; }
        public double? WorkMins { get; set; }
    }
}
