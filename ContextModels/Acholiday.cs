using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class Acholiday
    {
        public int Primaryid { get; set; }
        public int? Holidayid { get; set; }
        public DateTime? Begindate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Timezone { get; set; }
    }
}
