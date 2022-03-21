using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class Securitydetail
    {
        public int Securitydetailid { get; set; }
        public int? UserId { get; set; }
        public short? Deptid { get; set; }
        public short? Schedule { get; set; }
        public short? Userinfo { get; set; }
        public short? Enrollfingers { get; set; }
        public short? Reportview { get; set; }
        public string? Report { get; set; }
        public bool? ReadOnly { get; set; }
        public bool? FullControl { get; set; }
    }
}
