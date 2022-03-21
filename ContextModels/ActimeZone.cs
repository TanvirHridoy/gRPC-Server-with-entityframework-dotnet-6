using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class ActimeZone
    {
        public short TimeZoneId { get; set; }
        public string? Name { get; set; }
        public DateTime? SunStart { get; set; }
        public DateTime? SunEnd { get; set; }
        public DateTime? MonStart { get; set; }
        public DateTime? MonEnd { get; set; }
        public DateTime? TuesStart { get; set; }
        public DateTime? TuesEnd { get; set; }
        public DateTime? WedStart { get; set; }
        public DateTime? WedEnd { get; set; }
        public DateTime? ThursStart { get; set; }
        public DateTime? ThursEnd { get; set; }
        public DateTime? FriStart { get; set; }
        public DateTime? FriEnd { get; set; }
        public DateTime? SatStart { get; set; }
        public DateTime? SatEnd { get; set; }
    }
}
