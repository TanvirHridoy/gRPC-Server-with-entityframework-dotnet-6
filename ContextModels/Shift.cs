using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class Shift
    {
        public int Shiftid { get; set; }
        public string? Name { get; set; }
        public int? Ushiftid { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Runnum { get; set; }
        public int? Sch1 { get; set; }
        public int? Sch2 { get; set; }
        public int? Sch3 { get; set; }
        public int? Sch4 { get; set; }
        public int? Sch5 { get; set; }
        public int? Sch6 { get; set; }
        public int? Sch7 { get; set; }
        public int? Sch8 { get; set; }
        public int? Sch9 { get; set; }
        public int? Sch10 { get; set; }
        public int? Sch11 { get; set; }
        public int? Sch12 { get; set; }
        public short? Cycle { get; set; }
        public short? Units { get; set; }
    }
}
