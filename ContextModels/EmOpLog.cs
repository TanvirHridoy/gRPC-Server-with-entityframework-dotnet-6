using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class EmOpLog
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public DateTime OperateTime { get; set; }
        public int? ManipulationId { get; set; }
        public int? Params1 { get; set; }
        public int? Params2 { get; set; }
        public int? Params3 { get; set; }
        public int? Params4 { get; set; }
        public string? SensorId { get; set; }
    }
}
