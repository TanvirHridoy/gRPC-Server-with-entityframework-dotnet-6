using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class Userinfo
    {
        public int Userid { get; set; }
        public string Badgenumber { get; set; } = null!;
        public string? Ssn { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Title { get; set; }
        public string? Pager { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? Hiredday { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Ophone { get; set; }
        public string? Fphone { get; set; }
        public short? Verificationmethod { get; set; }
        public short? Defaultdeptid { get; set; }
        public short? Securityflags { get; set; }
        public short? Att { get; set; }
        public short? Inlate { get; set; }
        public short? Outearly { get; set; }
        public short? Overtime { get; set; }
        public short? Sep { get; set; }
        public short? Holiday { get; set; }
        public string? Minzu { get; set; }
        public string? Password { get; set; }
        public short? Lunchduration { get; set; }
        public byte[]? Photo { get; set; }
        public string? Mverifypass { get; set; }
        public byte[]? Notes { get; set; }
        public int? Privilege { get; set; }
        public short? InheritDeptSch { get; set; }
        public short? InheritDeptSchClass { get; set; }
        public short? AutoSchPlan { get; set; }
        public int? MinAutoSchInterval { get; set; }
        public short? RegisterOt { get; set; }
        public short? InheritDeptRule { get; set; }
        public short? Emprivilege { get; set; }
        public string? CardNo { get; set; }
        public int? FaceGroup { get; set; }
        public int? AccGroup { get; set; }
        public int? UseAccGroupTz { get; set; }
        public int? VerifyCode { get; set; }
        public int? Expires { get; set; }
        public int? ValidCount { get; set; }
        public DateTime? ValidTimeBegin { get; set; }
        public DateTime? ValidTimeEnd { get; set; }
        public int? TimeZone1 { get; set; }
        public int? TimeZone2 { get; set; }
        public int? TimeZone3 { get; set; }
    }
}
