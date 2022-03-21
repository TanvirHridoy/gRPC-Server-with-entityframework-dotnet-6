using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class UserSpeday
    {
        public int Userid { get; set; }
        public DateTime Startspecday { get; set; }
        public DateTime? Endspecday { get; set; }
        public short Dateid { get; set; }
        public string? Yuanying { get; set; }
        public DateTime? Date { get; set; }
    }
}
