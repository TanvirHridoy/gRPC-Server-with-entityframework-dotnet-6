using Grpc.Core;
using GrpcService1;
using GrpcService1.ContextModels;
using Microsoft.EntityFrameworkCore;

namespace GrpcService1.Services
{
    public class AttendanceService : Attendance.AttendanceBase
    {
        private readonly ILogger<AttendanceService> _logger;
        private readonly HRMContext _context;

        public AttendanceService(ILogger<AttendanceService> logger,HRMContext context)
        {
            _logger = logger;
            _context = context; 
        }

        public async Task<List<PrmEmpAttendance>> GetAttendanceAsync(string EMPID,DateTime date)
        {

            return await _context.PrmEmpAttendances.Where(e => e.EmpId == EMPID ).ToListAsync();
        }

        public override async Task GetAttendance(AttendanceRequest request, IServerStreamWriter<AttendanceReply> responseStream, ServerCallContext context)
        {
            var list = await GetAttendanceAsync(request.Empid, Convert.ToDateTime(request.Date));

            foreach (var item in list)
            {
                //await Task.Delay(100);
                await responseStream.WriteAsync(new AttendanceReply
                {
                    Attdatetime = item.AttDateTime.ToString("dd-MMM-yyyy hh:mm tt"),
                    Atttype=item.AttType,
                     Empid=item.EmpId
                });
            }
        }
    }
}