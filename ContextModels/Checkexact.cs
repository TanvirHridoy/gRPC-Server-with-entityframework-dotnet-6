using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class Checkexact
    {
        public int Exactid { get; set; }
        public int? Userid { get; set; }
        public DateTime? Checktime { get; set; }
        public string? Checktype { get; set; }
        public short? Isadd { get; set; }
        public string? Yuyin { get; set; }
        public short? Ismodify { get; set; }
        public short? Isdelete { get; set; }
        public short? Incount { get; set; }
        public short? Iscount { get; set; }
        public string? Modifyby { get; set; }
        public DateTime? Date { get; set; }
    }
}
