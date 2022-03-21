using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class Holiday
    {
        public int Holidayid { get; set; }
        public string? Holidayname { get; set; }
        public short? Holidayyear { get; set; }
        public short? Holidaymonth { get; set; }
        public short? Holidayday { get; set; }
        public DateTime? Starttime { get; set; }
        public short? Duration { get; set; }
        public short? Holidaytype { get; set; }
        public string? Xinbie { get; set; }
        public string? Minzu { get; set; }
        public short? DeptId { get; set; }
        public int? Timezone { get; set; }
    }
}
