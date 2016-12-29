using System;
using System.Web.Services;

namespace FinReportWebService
{

    public class FinReportService
    {
        [WebMethod]
        public int[] GetReportIdArray(DateTime dateBegin, DateTime dateEnd)
        {
            int[] array = new int[] { 357, 358, 360, 361 };
            return array;
        }

        [WebMethod(Description = "My Time Zone")]
        public string My_timeZone()
        {
            return MyHour();
        }

        [WebMethod]
        public FinReport GetReport(int reportID)
        {
            FinReport finReport = new FinReport()
            {
                ReportID = reportID,
                Date = new DateTime(2015, 03, 15),
                Info = "Some info"
            };

            return finReport;
        }

        [WebMethod]
        public String TimeZones(String Time)
        {
            return String.Format("Input time {0}", Time);
        }
        public string MyHour()
        {
            DateTime localDate = DateTime.Now;
            return Convert.ToString(localDate.ToLongDateString()) + " " + Convert.ToString(localDate.ToLongTimeString());
        }
    }
    
    public class FinReport
    {
        public String Time;
        public int ReportID { get; set; }
        public DateTime Date { get; set; }
        public string Info { get; set; }
    }
}