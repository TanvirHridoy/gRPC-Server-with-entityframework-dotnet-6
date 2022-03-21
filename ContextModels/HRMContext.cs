using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GrpcService1.ContextModels
{
    public partial class HRMContext : DbContext
    {
        public HRMContext()
        {
        }

        public HRMContext(DbContextOptions<HRMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acgroup> Acgroups { get; set; } = null!;
        public virtual DbSet<Acholiday> Acholidays { get; set; } = null!;
        public virtual DbSet<ActimeZone> ActimeZones { get; set; } = null!;
        public virtual DbSet<AcunlockComb> AcunlockCombs { get; set; } = null!;
        public virtual DbSet<AlarmLog> AlarmLogs { get; set; } = null!;
        public virtual DbSet<AttParam> AttParams { get; set; } = null!;
        public virtual DbSet<AuditedExc> AuditedExcs { get; set; } = null!;
        public virtual DbSet<Authdevice> Authdevices { get; set; } = null!;
        public virtual DbSet<Checkexact> Checkexacts { get; set; } = null!;
        public virtual DbSet<Checkinout> Checkinouts { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DeptUsedSch> DeptUsedSchs { get; set; } = null!;
        public virtual DbSet<EmOpLog> EmOpLogs { get; set; } = null!;
        public virtual DbSet<Excnote> Excnotes { get; set; } = null!;
        public virtual DbSet<FaceTemp> FaceTemps { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<LeaveClass> LeaveClasses { get; set; } = null!;
        public virtual DbSet<LeaveClass1> LeaveClass1s { get; set; } = null!;
        public virtual DbSet<Machine> Machines { get; set; } = null!;
        public virtual DbSet<NumRun> NumRuns { get; set; } = null!;
        public virtual DbSet<NumRunDeil> NumRunDeils { get; set; } = null!;
        public virtual DbSet<PrmEmpAttendance> PrmEmpAttendances { get; set; } = null!;
        public virtual DbSet<ReportItem> ReportItems { get; set; } = null!;
        public virtual DbSet<SchClass> SchClasses { get; set; } = null!;
        public virtual DbSet<Securitydetail> Securitydetails { get; set; } = null!;
        public virtual DbSet<ServerLog> ServerLogs { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;
        public virtual DbSet<SystemLog> SystemLogs { get; set; } = null!;
        public virtual DbSet<Tbkey> Tbkeys { get; set; } = null!;
        public virtual DbSet<Tbsmsallot> Tbsmsallots { get; set; } = null!;
        public virtual DbSet<Tbsmsinfo> Tbsmsinfos { get; set; } = null!;
        public virtual DbSet<Template> Templates { get; set; } = null!;
        public virtual DbSet<UserAcmachine> UserAcmachines { get; set; } = null!;
        public virtual DbSet<UserAcprivilege> UserAcprivileges { get; set; } = null!;
        public virtual DbSet<UserOfRun> UserOfRuns { get; set; } = null!;
        public virtual DbSet<UserSpeday> UserSpedays { get; set; } = null!;
        public virtual DbSet<UserTempSch> UserTempSches { get; set; } = null!;
        public virtual DbSet<UserUpdate> UserUpdates { get; set; } = null!;
        public virtual DbSet<UserUsedSclass> UserUsedSclasses { get; set; } = null!;
        public virtual DbSet<Userinfo> Userinfos { get; set; } = null!;
        public virtual DbSet<UsersMachine> UsersMachines { get; set; } = null!;
        public virtual DbSet<ZkattendanceMonthStatistic> ZkattendanceMonthStatistics { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=HRIDOYPCWORK\\SQL2K12EXP;Database=DB_ATTN_NEW;User ID=sa;Password=1234;MultipleActiveResultSets=true ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acgroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("ACGroup$Index_D86F8037_B87F_4A67");

                entity.ToTable("ACGroup");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("GroupID");

                entity.Property(e => e.Holidayvaild)
                    .HasColumnName("holidayvaild")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.TimeZone1).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeZone2).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeZone3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Verifystyle).HasColumnName("verifystyle");
            });

            modelBuilder.Entity<Acholiday>(entity =>
            {
                entity.HasKey(e => e.Primaryid)
                    .HasName("acholiday$PrimaryKey");

                entity.ToTable("acholiday");

                entity.HasIndex(e => e.Holidayid, "acholiday$holidayid");

                entity.Property(e => e.Primaryid).HasColumnName("primaryid");

                entity.Property(e => e.Begindate)
                    .HasColumnType("datetime")
                    .HasColumnName("begindate");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("enddate");

                entity.Property(e => e.Holidayid).HasColumnName("holidayid");

                entity.Property(e => e.Timezone).HasColumnName("timezone");
            });

            modelBuilder.Entity<ActimeZone>(entity =>
            {
                entity.HasKey(e => e.TimeZoneId)
                    .HasName("ACTimeZones$Index_9EF13579_8C36_4679");

                entity.ToTable("ACTimeZones");

                entity.Property(e => e.TimeZoneId)
                    .ValueGeneratedNever()
                    .HasColumnName("TimeZoneID");

                entity.Property(e => e.FriEnd).HasColumnType("datetime");

                entity.Property(e => e.FriStart).HasColumnType("datetime");

                entity.Property(e => e.MonEnd).HasColumnType("datetime");

                entity.Property(e => e.MonStart).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.SatEnd).HasColumnType("datetime");

                entity.Property(e => e.SatStart).HasColumnType("datetime");

                entity.Property(e => e.SunEnd).HasColumnType("datetime");

                entity.Property(e => e.SunStart).HasColumnType("datetime");

                entity.Property(e => e.ThursEnd).HasColumnType("datetime");

                entity.Property(e => e.ThursStart).HasColumnType("datetime");

                entity.Property(e => e.TuesEnd).HasColumnType("datetime");

                entity.Property(e => e.TuesStart).HasColumnType("datetime");

                entity.Property(e => e.WedEnd).HasColumnType("datetime");

                entity.Property(e => e.WedStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<AcunlockComb>(entity =>
            {
                entity.HasKey(e => e.UnlockCombId)
                    .HasName("ACUnlockComb$Index_BD290E32_43BB_4DBE");

                entity.ToTable("ACUnlockComb");

                entity.Property(e => e.UnlockCombId)
                    .ValueGeneratedNever()
                    .HasColumnName("UnlockCombID");

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<AlarmLog>(entity =>
            {
                entity.ToTable("AlarmLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnrollNumber).HasMaxLength(30);

                entity.Property(e => e.LogTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MachineAlias).HasMaxLength(20);

                entity.Property(e => e.Operator).HasMaxLength(20);
            });

            modelBuilder.Entity<AttParam>(entity =>
            {
                entity.HasKey(e => e.Paraname)
                    .HasName("AttParam$Index_DD188E0E_5A38_448C");

                entity.ToTable("AttParam");

                entity.Property(e => e.Paraname)
                    .HasMaxLength(20)
                    .HasColumnName("PARANAME");

                entity.Property(e => e.Paratype)
                    .HasMaxLength(2)
                    .HasColumnName("PARATYPE");

                entity.Property(e => e.Paravalue)
                    .HasMaxLength(100)
                    .HasColumnName("PARAVALUE");
            });

            modelBuilder.Entity<AuditedExc>(entity =>
            {
                entity.HasKey(e => e.Aeid)
                    .HasName("AuditedExc$Index_242CBB44_8583_4AB4");

                entity.ToTable("AuditedExc");

                entity.Property(e => e.Aeid).HasColumnName("AEID");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.NewExcId).HasColumnName("NewExcID");

                entity.Property(e => e.Uname)
                    .HasMaxLength(20)
                    .HasColumnName("UName");

                entity.Property(e => e.Utime)
                    .HasColumnType("datetime")
                    .HasColumnName("UTime");
            });

            modelBuilder.Entity<Authdevice>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.MachineId })
                    .HasName("AUTHDEVICE$AUTHKEY");

                entity.ToTable("AUTHDEVICE");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Checkexact>(entity =>
            {
                entity.HasKey(e => e.Exactid)
                    .HasName("CHECKEXACT$PrimaryKey");

                entity.ToTable("CHECKEXACT");

                entity.HasIndex(e => e.Exactid, "CHECKEXACT$EXACTID");

                entity.Property(e => e.Exactid).HasColumnName("EXACTID");

                entity.Property(e => e.Checktime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHECKTIME");

                entity.Property(e => e.Checktype)
                    .HasMaxLength(2)
                    .HasColumnName("CHECKTYPE");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Incount).HasColumnName("INCOUNT");

                entity.Property(e => e.Isadd).HasColumnName("ISADD");

                entity.Property(e => e.Iscount).HasColumnName("ISCOUNT");

                entity.Property(e => e.Isdelete).HasColumnName("ISDELETE");

                entity.Property(e => e.Ismodify).HasColumnName("ISMODIFY");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(20)
                    .HasColumnName("MODIFYBY")
                    .HasDefaultValueSql("('Temp-Supervisor')");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Yuyin)
                    .HasMaxLength(25)
                    .HasColumnName("YUYIN");
            });

            modelBuilder.Entity<Checkinout>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Checktime })
                    .HasName("CHECKINOUT$Index_FBDDB8A2_33F1_4744");

                entity.ToTable("CHECKINOUT");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Checktime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHECKTIME")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Checktype)
                    .HasMaxLength(1)
                    .HasColumnName("CHECKTYPE")
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.Chkrowid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CHKROWID");

                entity.Property(e => e.Isupdated).HasColumnName("ISUpdated");

                entity.Property(e => e.Memoinfo).HasMaxLength(30);

                entity.Property(e => e.Sensorid)
                    .HasMaxLength(5)
                    .HasColumnName("SENSORID");

                entity.Property(e => e.Sn)
                    .HasMaxLength(20)
                    .HasColumnName("sn");

                entity.Property(e => e.UserExtFmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Verifycode)
                    .HasColumnName("VERIFYCODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkCode)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Deptid)
                    .HasName("DEPARTMENTS$Index_12256B17_45F9_4BE1");

                entity.ToTable("DEPARTMENTS");

                entity.HasIndex(e => e.Deptname, "DEPARTMENTS$DEPTNAME");

                entity.Property(e => e.Deptid).HasColumnName("DEPTID");

                entity.Property(e => e.Att)
                    .HasColumnName("ATT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AutoSchPlan).HasDefaultValueSql("((1))");

                entity.Property(e => e.DefaultSchId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Deptname)
                    .HasMaxLength(30)
                    .HasColumnName("DEPTNAME");

                entity.Property(e => e.Holiday).HasDefaultValueSql("((1))");

                entity.Property(e => e.InLate).HasDefaultValueSql("((1))");

                entity.Property(e => e.InheritDeptRule).HasDefaultValueSql("((1))");

                entity.Property(e => e.InheritDeptSch).HasDefaultValueSql("((1))");

                entity.Property(e => e.InheritDeptSchClass).HasDefaultValueSql("((1))");

                entity.Property(e => e.InheritParentSch).HasDefaultValueSql("((1))");

                entity.Property(e => e.MinAutoSchInterval).HasDefaultValueSql("((24))");

                entity.Property(e => e.OutEarly).HasDefaultValueSql("((1))");

                entity.Property(e => e.OverTime).HasDefaultValueSql("((1))");

                entity.Property(e => e.RegisterOt)
                    .HasColumnName("RegisterOT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Supdeptid)
                    .HasColumnName("SUPDEPTID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DeptUsedSch>(entity =>
            {
                entity.HasKey(e => new { e.DeptId, e.SchId })
                    .HasName("DeptUsedSchs$DEPT_USED_SCH");
            });

            modelBuilder.Entity<EmOpLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmOpLog");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ManipulationId).HasColumnName("manipulationID");

                entity.Property(e => e.OperateTime).HasColumnType("datetime");

                entity.Property(e => e.SensorId).HasMaxLength(5);

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Excnote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EXCNOTES");

                entity.HasIndex(e => new { e.Userid, e.Attdate }, "EXCNOTES$EXCNOTE")
                    .IsUnique();

                entity.Property(e => e.Attdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ATTDATE");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .HasColumnName("NOTES");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<FaceTemp>(entity =>
            {
                entity.HasKey(e => e.Templateid)
                    .HasName("FaceTemp$Index_315CBFEA_09D3_4FC8");

                entity.ToTable("FaceTemp");

                entity.HasIndex(e => e.Faceid, "FaceTemp$FACEID");

                entity.HasIndex(e => e.Templateid, "FaceTemp$TEMPLATEID");

                entity.HasIndex(e => e.Userno, "FaceTemp$USERNO");

                entity.HasIndex(e => e.Valid, "FaceTemp$VALID");

                entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");

                entity.Property(e => e.Activetime)
                    .HasColumnName("ACTIVETIME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Faceid)
                    .HasColumnName("FACEID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pin)
                    .HasColumnName("pin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Reserve)
                    .HasColumnName("RESERVE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Size)
                    .HasColumnName("SIZE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Template)
                    .HasColumnType("image")
                    .HasColumnName("TEMPLATE");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Userno)
                    .HasMaxLength(24)
                    .HasColumnName("USERNO");

                entity.Property(e => e.Valid)
                    .HasColumnName("VALID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vfcount)
                    .HasColumnName("VFCOUNT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("HOLIDAYS");

                entity.HasIndex(e => e.Holidayname, "HOLIDAYS$HOLIDAYNAME")
                    .IsUnique();

                entity.Property(e => e.Holidayid).HasColumnName("HOLIDAYID");

                entity.Property(e => e.DeptId)
                    .HasColumnName("DeptID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.Holidayday)
                    .HasColumnName("HOLIDAYDAY")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Holidaymonth).HasColumnName("HOLIDAYMONTH");

                entity.Property(e => e.Holidayname)
                    .HasMaxLength(20)
                    .HasColumnName("HOLIDAYNAME");

                entity.Property(e => e.Holidaytype).HasColumnName("HOLIDAYTYPE");

                entity.Property(e => e.Holidayyear).HasColumnName("HOLIDAYYEAR");

                entity.Property(e => e.Minzu)
                    .HasMaxLength(50)
                    .HasColumnName("MINZU");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Timezone)
                    .HasColumnName("timezone")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Xinbie)
                    .HasMaxLength(4)
                    .HasColumnName("XINBIE");
            });

            modelBuilder.Entity<LeaveClass>(entity =>
            {
                entity.HasKey(e => e.LeaveId)
                    .HasName("LeaveClass$Index_EB3AE9CA_0DD3_463A");

                entity.ToTable("LeaveClass");

                entity.Property(e => e.Classify).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinUnit).HasDefaultValueSql("((1))");

                entity.Property(e => e.RemaindCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.RemaindProc).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportSymbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Unit).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LeaveClass1>(entity =>
            {
                entity.HasKey(e => e.LeaveId)
                    .HasName("LeaveClass1$Index_A94FDFEF_6B14_486B");

                entity.ToTable("LeaveClass1");

                entity.Property(e => e.Calc).HasColumnType("text");

                entity.Property(e => e.LeaveName).HasMaxLength(20);

                entity.Property(e => e.MinUnit).HasDefaultValueSql("((1))");

                entity.Property(e => e.RemaindCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.RemaindProc).HasDefaultValueSql("((2))");

                entity.Property(e => e.ReportSymbol)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('-')");
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateFormat).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fingercount)
                    .HasColumnName("fingercount")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.FirmwareVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idle).HasDefaultValueSql("((-1))");

                entity.Property(e => e.InOutRecordWarn).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .HasColumnName("IP");

                entity.Property(e => e.IsAndroid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsHost).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIfChangeConfigServer2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LockControl).HasDefaultValueSql("((-1))");

                entity.Property(e => e.MachineAlias).HasMaxLength(20);

                entity.Property(e => e.MachineNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Managercount)
                    .HasColumnName("managercount")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.PhotoStamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Port).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProduceKind).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose).HasDefaultValueSql("((1))");

                entity.Property(e => e.Pushver)
                    .HasColumnName("pushver")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SecretCount).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SerialPort).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sn");

                entity.Property(e => e.Uilanguage)
                    .HasColumnName("UILanguage")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Usercount)
                    .HasColumnName("usercount")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Voice).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<NumRun>(entity =>
            {
                entity.ToTable("NUM_RUN");

                entity.Property(e => e.NumRunid).HasColumnName("NUM_RUNID");

                entity.Property(e => e.Cyle)
                    .HasColumnName("CYLE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE")
                    .HasDefaultValueSql("('2099-12-31')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Oldid)
                    .HasColumnName("OLDID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE")
                    .HasDefaultValueSql("('1900-1-1')");

                entity.Property(e => e.Units)
                    .HasColumnName("UNITS")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<NumRunDeil>(entity =>
            {
                entity.HasKey(e => new { e.NumRunid, e.Sdays, e.Starttime })
                    .HasName("NUM_RUN_DEIL$Index_E91501C7_FB87_4DD4");

                entity.ToTable("NUM_RUN_DEIL");

                entity.Property(e => e.NumRunid).HasColumnName("NUM_RUNID");

                entity.Property(e => e.Sdays).HasColumnName("SDAYS");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Edays).HasColumnName("EDAYS");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Schclassid)
                    .HasColumnName("SCHCLASSID")
                    .HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<PrmEmpAttendance>(entity =>
            {
                entity.HasKey(e => e.AttId);

                entity.ToTable("PRM_EMP_ATTENDANCE", "bhr");

                entity.Property(e => e.AttId).HasColumnName("ATT_ID");

                entity.Property(e => e.AccessMachine)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCESS_MACHINE");

                entity.Property(e => e.AccessMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCESS_METHOD")
                    .HasDefaultValueSql("('Face')");

                entity.Property(e => e.ApplyLateDeduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APPLY_LATE_DEDUCT")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ApprovalComment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_COMMENT");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_STATUS");

                entity.Property(e => e.ApprovedbyHr)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Approvedby_HR");

                entity.Property(e => e.ApprovedbyInitial)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Approvedby_Initial");

                entity.Property(e => e.AttComments)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ATT_COMMENTS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AttDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("ATT_DATE_TIME")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AttLateStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ATT_LATE_STATUS")
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.AttType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ATT_TYPE");

                entity.Property(e => e.AttendanceModified)
                    .HasColumnName("Attendance_Modified")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMP_ID");

                entity.Property(e => e.InsertTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OsdApprovedbyHr)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OSD_Approvedby_HR");

                entity.Property(e => e.OsdApprovedbyInitial)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OSD_Approvedby_Initial");

                entity.Property(e => e.PrUpdateLateStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PR_UPDATE_LATE_STATUS")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RosterTime).HasColumnName("ROSTER_TIME");
            });

            modelBuilder.Entity<ReportItem>(entity =>
            {
                entity.HasKey(e => e.Riid)
                    .HasName("ReportItem$Index_532D27E1_C340_4200");

                entity.ToTable("ReportItem");

                entity.Property(e => e.Riid).HasColumnName("RIID");

                entity.Property(e => e.Notes).HasColumnType("image");

                entity.Property(e => e.Riindex).HasColumnName("RIIndex");

                entity.Property(e => e.Riname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RIName");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SchClass>(entity =>
            {
                entity.ToTable("SchClass");

                entity.Property(e => e.SchClassid).HasColumnName("schClassid");

                entity.Property(e => e.AutoBind).HasDefaultValueSql("((1))");

                entity.Property(e => e.CheckIn).HasDefaultValueSql("((1))");

                entity.Property(e => e.CheckInTime1).HasColumnType("datetime");

                entity.Property(e => e.CheckInTime2).HasColumnType("datetime");

                entity.Property(e => e.CheckOut).HasDefaultValueSql("((1))");

                entity.Property(e => e.CheckOutTime1).HasColumnType("datetime");

                entity.Property(e => e.CheckOutTime2).HasColumnType("datetime");

                entity.Property(e => e.Color).HasDefaultValueSql("((16715535))");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.SchName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("schName")
                    .HasDefaultValueSql("('?')");

                entity.Property(e => e.SensorId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SensorID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.WorkDay).HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkMins).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Securitydetail>(entity =>
            {
                entity.ToTable("SECURITYDETAILS");

                entity.Property(e => e.Securitydetailid).HasColumnName("SECURITYDETAILID");

                entity.Property(e => e.Deptid).HasColumnName("DEPTID");

                entity.Property(e => e.Enrollfingers).HasColumnName("ENROLLFINGERS");

                entity.Property(e => e.FullControl).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReadOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.Report)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPORT");

                entity.Property(e => e.Reportview).HasColumnName("REPORTVIEW");

                entity.Property(e => e.Schedule).HasColumnName("SCHEDULE");

                entity.Property(e => e.Userinfo).HasColumnName("USERINFO");
            });

            modelBuilder.Entity<ServerLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServerLog");

                entity.Property(e => e.EnrollNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Event)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EVENT");

                entity.Property(e => e.Eventtime)
                    .HasColumnType("datetime")
                    .HasColumnName("EVENTTIME");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPERATOR");

                entity.Property(e => e.Parameter).HasColumnName("parameter");

                entity.Property(e => e.Sensorid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SENSORID");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("SHIFT");

                entity.Property(e => e.Shiftid).HasColumnName("SHIFTID");

                entity.Property(e => e.Cycle)
                    .HasColumnName("CYCLE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE")
                    .HasDefaultValueSql("('1900-12-31')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Runnum)
                    .HasColumnName("RUNNUM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch1)
                    .HasColumnName("SCH1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch10)
                    .HasColumnName("SCH10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch11)
                    .HasColumnName("SCH11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch12)
                    .HasColumnName("SCH12")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch2)
                    .HasColumnName("SCH2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch3)
                    .HasColumnName("SCH3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch4)
                    .HasColumnName("SCH4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch5)
                    .HasColumnName("SCH5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch6)
                    .HasColumnName("SCH6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch7)
                    .HasColumnName("SCH7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch8)
                    .HasColumnName("SCH8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sch9)
                    .HasColumnName("SCH9")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE")
                    .HasDefaultValueSql("('1900-1-1')");

                entity.Property(e => e.Units)
                    .HasColumnName("UNITS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ushiftid)
                    .HasColumnName("USHIFTID")
                    .HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<SystemLog>(entity =>
            {
                entity.ToTable("SystemLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LogDescr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MachineAlias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbkey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBKEY");

                entity.Property(e => e.Onekey).HasColumnName("ONEKEY");

                entity.Property(e => e.PreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbsmsallot>(entity =>
            {
                entity.HasKey(e => e.Reference)
                    .HasName("TBSMSALLOT$Index_2B41633A_C73E_47B0");

                entity.ToTable("TBSMSALLOT");

                entity.Property(e => e.Reference)
                    .ValueGeneratedNever()
                    .HasColumnName("REFERENCE");

                entity.Property(e => e.Gentm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GENTM");

                entity.Property(e => e.Smsref).HasColumnName("SMSREF");

                entity.Property(e => e.Userref).HasColumnName("USERREF");
            });

            modelBuilder.Entity<Tbsmsinfo>(entity =>
            {
                entity.HasKey(e => e.Reference)
                    .HasName("TBSMSINFO$Index_790D54EC_EA59_4D8D");

                entity.ToTable("TBSMSINFO");

                entity.HasIndex(e => e.Smsid, "TBSMSINFO$UK_SMSINFOCode")
                    .IsUnique();

                entity.HasIndex(e => e.Smsid, "UK_SMSINFOCode")
                    .IsUnique();

                entity.Property(e => e.Reference)
                    .ValueGeneratedNever()
                    .HasColumnName("REFERENCE");

                entity.Property(e => e.Gentm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GENTM");

                entity.Property(e => e.Smscontent)
                    .HasColumnType("text")
                    .HasColumnName("SMSCONTENT");

                entity.Property(e => e.Smsid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMSID");

                entity.Property(e => e.Smsindex).HasColumnName("SMSINDEX");

                entity.Property(e => e.Smsstarttm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMSSTARTTM");

                entity.Property(e => e.Smstmleng).HasColumnName("SMSTMLENG");

                entity.Property(e => e.Smstype).HasColumnName("SMSTYPE");
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.ToTable("TEMPLATE");

                entity.HasIndex(e => new { e.Userid, e.Fingerid }, "TEMPLATE$USERFINGER")
                    .IsUnique();

                entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");

                entity.Property(e => e.Bitmappicture)
                    .HasColumnType("image")
                    .HasColumnName("BITMAPPICTURE");

                entity.Property(e => e.Bitmappicture2)
                    .HasColumnType("image")
                    .HasColumnName("BITMAPPICTURE2");

                entity.Property(e => e.Bitmappicture3)
                    .HasColumnType("image")
                    .HasColumnName("BITMAPPICTURE3");

                entity.Property(e => e.Bitmappicture4)
                    .HasColumnType("image")
                    .HasColumnName("BITMAPPICTURE4");

                entity.Property(e => e.DivisionFp)
                    .HasColumnName("DivisionFP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Emachinenum)
                    .HasMaxLength(3)
                    .HasColumnName("EMACHINENUM");

                entity.Property(e => e.Fingerid).HasColumnName("FINGERID");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Template1)
                    .HasColumnType("image")
                    .HasColumnName("TEMPLATE");

                entity.Property(e => e.Template11)
                    .HasColumnType("image")
                    .HasColumnName("TEMPLATE1");

                entity.Property(e => e.Template2)
                    .HasColumnType("image")
                    .HasColumnName("TEMPLATE2");

                entity.Property(e => e.Template3)
                    .HasColumnType("image")
                    .HasColumnName("TEMPLATE3");

                entity.Property(e => e.Template4)
                    .HasColumnType("image")
                    .HasColumnName("TEMPLATE4");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Usetype).HasColumnName("USETYPE");
            });

            modelBuilder.Entity<UserAcmachine>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Deviceid })
                    .HasName("UserACMachines$UserAC_Machines");

                entity.ToTable("UserACMachines");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserAcprivilege>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DeviceId })
                    .HasName("UserACPrivilege$pk_privilege");

                entity.ToTable("UserACPrivilege");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.AcgroupId).HasColumnName("ACGroupID");

                entity.Property(e => e.IsUseGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.Verifystyle).HasColumnName("verifystyle");
            });

            modelBuilder.Entity<UserOfRun>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.NumOfRunId, e.Startdate, e.Enddate })
                    .HasName("USER_OF_RUN$Index_6C3410BB_8A36_4078");

                entity.ToTable("USER_OF_RUN");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.NumOfRunId).HasColumnName("NUM_OF_RUN_ID");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE")
                    .HasDefaultValueSql("('1900-1-1')");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE")
                    .HasDefaultValueSql("('2099-12-31')");

                entity.Property(e => e.IsnotofRun)
                    .HasColumnName("ISNOTOF_RUN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderRun).HasColumnName("ORDER_RUN");
            });

            modelBuilder.Entity<UserSpeday>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Startspecday, e.Dateid })
                    .HasName("USER_SPEDAY$Index_55806E2A_861F_4852");

                entity.ToTable("USER_SPEDAY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Startspecday)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTSPECDAY")
                    .HasDefaultValueSql("('1900-1-1')");

                entity.Property(e => e.Dateid)
                    .HasColumnName("DATEID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Endspecday)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDSPECDAY")
                    .HasDefaultValueSql("('2099-12-31')");

                entity.Property(e => e.Yuanying)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("YUANYING");
            });

            modelBuilder.Entity<UserTempSch>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Cometime, e.Leavetime })
                    .HasName("USER_TEMP_SCH$Index_B9028242_B6B8_4B02");

                entity.ToTable("USER_TEMP_SCH");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Cometime)
                    .HasColumnType("datetime")
                    .HasColumnName("COMETIME");

                entity.Property(e => e.Leavetime)
                    .HasColumnType("datetime")
                    .HasColumnName("LEAVETIME");

                entity.Property(e => e.Flag)
                    .HasColumnName("FLAG")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Overtime)
                    .HasColumnName("OVERTIME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Schclassid)
                    .HasColumnName("SCHCLASSID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserUpdate>(entity =>
            {
                entity.HasKey(e => e.UpdateId)
                    .HasName("UserUpdates$Index_3E1FEDAF_9034_4CAF");

                entity.Property(e => e.BadgeNumber).HasMaxLength(20);
            });

            modelBuilder.Entity<UserUsedSclass>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SchId })
                    .HasName("UserUsedSClasses$USER_USED_SCL");

                entity.ToTable("UserUsedSClasses");
            });

            modelBuilder.Entity<Userinfo>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("USERINFO$Index_37D1A1C3_AF9B_4B1E");

                entity.ToTable("USERINFO");

                entity.HasIndex(e => e.Badgenumber, "USERINFO$BADGENUMBER")
                    .IsUnique();

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.AccGroup).HasDefaultValueSql("((1))");

                entity.Property(e => e.Att)
                    .HasColumnName("ATT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AutoSchPlan).HasDefaultValueSql("((1))");

                entity.Property(e => e.Badgenumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("BIRTHDAY");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Defaultdeptid)
                    .HasColumnName("DEFAULTDEPTID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Emprivilege)
                    .HasColumnName("EMPRIVILEGE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Expires).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaceGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FPHONE");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hiredday)
                    .HasColumnType("datetime")
                    .HasColumnName("HIREDDAY");

                entity.Property(e => e.Holiday)
                    .HasColumnName("HOLIDAY")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InheritDeptRule).HasDefaultValueSql("((1))");

                entity.Property(e => e.InheritDeptSch).HasDefaultValueSql("((1))");

                entity.Property(e => e.InheritDeptSchClass).HasDefaultValueSql("((1))");

                entity.Property(e => e.Inlate)
                    .HasColumnName("INLATE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lunchduration)
                    .HasColumnName("LUNCHDURATION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MinAutoSchInterval).HasDefaultValueSql("((24))");

                entity.Property(e => e.Minzu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MINZU");

                entity.Property(e => e.Mverifypass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mverifypass");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("image");

                entity.Property(e => e.Ophone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPHONE");

                entity.Property(e => e.Outearly)
                    .HasColumnName("OUTEARLY")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Overtime)
                    .HasColumnName("OVERTIME")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pager)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PAGER");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Photo)
                    .HasColumnType("image")
                    .HasColumnName("PHOTO");

                entity.Property(e => e.Privilege)
                    .HasColumnName("privilege")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegisterOt)
                    .HasColumnName("RegisterOT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Securityflags).HasColumnName("SECURITYFLAGS");

                entity.Property(e => e.Sep)
                    .HasColumnName("SEP")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATE");

                entity.Property(e => e.Street)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("street");

                entity.Property(e => e.TimeZone1).HasDefaultValueSql("((1))");

                entity.Property(e => e.TimeZone2).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeZone3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.UseAccGroupTz)
                    .HasColumnName("UseAccGroupTZ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ValidCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValidTimeBegin).HasColumnType("datetime");

                entity.Property(e => e.ValidTimeEnd).HasColumnType("datetime");

                entity.Property(e => e.Verificationmethod).HasColumnName("VERIFICATIONMETHOD");

                entity.Property(e => e.VerifyCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZIP");
            });

            modelBuilder.Entity<UsersMachine>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Deviceid).HasColumnName("DEVICEID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<ZkattendanceMonthStatistic>(entity =>
            {
                entity.ToTable("ZKAttendanceMonthStatistics");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
