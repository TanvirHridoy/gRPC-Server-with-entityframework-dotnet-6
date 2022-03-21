using System;
using System.Collections.Generic;

namespace GrpcService1.ContextModels
{
    public partial class ZkattendanceMonthStatistic
    {
        public int Id { get; set; }
        public int? Userid { get; set; }
        public int? PortalSite { get; set; }
        public int? Department { get; set; }
        public int? Employee { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public double? YingDao { get; set; }
        public double? ShiDao { get; set; }
        public double? ChiDao { get; set; }
        public double? ZaoTui { get; set; }
        public double? KuangGong { get; set; }
        public double? JiaBan { get; set; }
        public double? WaiChu { get; set; }
        public double? YinGongWaiChu { get; set; }
        public double? GongZuoShiJian { get; set; }
        public double? YingQian { get; set; }
        public double? QianDao { get; set; }
        public double? QianTui { get; set; }
        public double? WeiQianDao { get; set; }
        public double? WeiQianTui { get; set; }
        public double? QingJia { get; set; }
        public double? PingRi { get; set; }
        public double? ZhouMo { get; set; }
        public double? JieJiaRi { get; set; }
        public double? ChuQinShiJian { get; set; }
        public double? PingRiJiaBan { get; set; }
        public double? ZhouMoJiaBan { get; set; }
        public double? JieJiaRiJiaBan { get; set; }
    }
}
