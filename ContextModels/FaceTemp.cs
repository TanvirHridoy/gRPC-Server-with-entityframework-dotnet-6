using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class FaceTemp
    {
        public int Templateid { get; set; }
        public string? Userno { get; set; }
        public int? Size { get; set; }
        public int? Pin { get; set; }
        public int? Faceid { get; set; }
        public int? Valid { get; set; }
        public int? Reserve { get; set; }
        public int? Activetime { get; set; }
        public int? Vfcount { get; set; }
        public byte[]? Template { get; set; }
        public int? UserId { get; set; }
    }
}
