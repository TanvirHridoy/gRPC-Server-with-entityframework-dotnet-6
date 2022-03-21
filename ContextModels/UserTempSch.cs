using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class UserTempSch
    {
        public int Userid { get; set; }
        public DateTime Cometime { get; set; }
        public DateTime Leavetime { get; set; }
        public short? Type { get; set; }
        public short? Flag { get; set; }
        public int? Schclassid { get; set; }
        public int? Overtime { get; set; }
    }
}
