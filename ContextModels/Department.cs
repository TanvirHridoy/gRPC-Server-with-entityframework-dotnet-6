using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class Department
    {
        public int Deptid { get; set; }
        public string? Deptname { get; set; }
        public int Supdeptid { get; set; }
        public short? InheritParentSch { get; set; }
        public short? InheritDeptSch { get; set; }
        public short? InheritDeptSchClass { get; set; }
        public short? AutoSchPlan { get; set; }
        public short? InLate { get; set; }
        public short? OutEarly { get; set; }
        public short? InheritDeptRule { get; set; }
        public int? MinAutoSchInterval { get; set; }
        public short? RegisterOt { get; set; }
        public int DefaultSchId { get; set; }
        public short? Att { get; set; }
        public short? Holiday { get; set; }
        public short? OverTime { get; set; }
    }
}
