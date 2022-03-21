using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class Template
    {
        public int Templateid { get; set; }
        public int Userid { get; set; }
        public int Fingerid { get; set; }
        public byte[] Template1 { get; set; } = null!;
        public byte[]? Template2 { get; set; }
        public byte[]? Bitmappicture { get; set; }
        public byte[]? Bitmappicture2 { get; set; }
        public byte[]? Bitmappicture3 { get; set; }
        public byte[]? Bitmappicture4 { get; set; }
        public short? Usetype { get; set; }
        public string? Emachinenum { get; set; }
        public byte[]? Template11 { get; set; }
        public short? Flag { get; set; }
        public short? DivisionFp { get; set; }
        public byte[]? Template4 { get; set; }
        public byte[]? Template3 { get; set; }
    }
}
