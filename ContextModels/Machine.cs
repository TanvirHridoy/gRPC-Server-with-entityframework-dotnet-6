using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class Machine
    {
        public int Id { get; set; }
        public string MachineAlias { get; set; } = null!;
        public int ConnectType { get; set; }
        public string? Ip { get; set; }
        public int? SerialPort { get; set; }
        public int? Port { get; set; }
        public int? Baudrate { get; set; }
        public int MachineNumber { get; set; }
        public bool? IsHost { get; set; }
        public bool? Enabled { get; set; }
        public string? CommPassword { get; set; }
        public short? Uilanguage { get; set; }
        public short? DateFormat { get; set; }
        public short? InOutRecordWarn { get; set; }
        public short? Idle { get; set; }
        public short? Voice { get; set; }
        public short? Managercount { get; set; }
        public short? Usercount { get; set; }
        public short? Fingercount { get; set; }
        public short? SecretCount { get; set; }
        public string? FirmwareVersion { get; set; }
        public string? ProductType { get; set; }
        public short? LockControl { get; set; }
        public short? Purpose { get; set; }
        public int? ProduceKind { get; set; }
        public string? Sn { get; set; }
        public string? PhotoStamp { get; set; }
        public int? IsIfChangeConfigServer2 { get; set; }
        public int? Pushver { get; set; }
        public string? IsAndroid { get; set; }
    }
}
