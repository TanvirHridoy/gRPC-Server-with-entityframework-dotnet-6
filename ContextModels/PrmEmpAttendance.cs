using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class PrmEmpAttendance
    {
        public long AttId { get; set; }
        public DateTime AttDateTime { get; set; }
        public string? AttType { get; set; }
        public string? AttLateStatus { get; set; }
        public string? AttComments { get; set; }
        public string? EmpId { get; set; }
        public string? ApplyLateDeduct { get; set; }
        public string? PrUpdateLateStatus { get; set; }
        public string? AccessMachine { get; set; }
        public string? AccessMethod { get; set; }
        public string? ApprovalComment { get; set; }
        public string? ApprovalStatus { get; set; }
        public int? RosterTime { get; set; }
        public bool? AttendanceModified { get; set; }
        public string? ApprovedbyInitial { get; set; }
        public string? ApprovedbyHr { get; set; }
        public string? OsdApprovedbyInitial { get; set; }
        public string? OsdApprovedbyHr { get; set; }
        public DateTime? InsertTime { get; set; }
        public string? Remarks { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
