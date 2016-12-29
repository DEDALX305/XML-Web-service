using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Threading;
using System.Net.Sockets;

namespace FinReportWebServiceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //public static FinReportService GetFinReportService()
        //{
        //    var service = new FinReportService();
        //    service.Url = "http://localhost:3500/FinReport.asmx";
        //    service.Timeout = 100 * 1000;
        //    return service;
        //}


        //private void webMethodTest_GetReportIdArray()
        //{
        //    var service = GetFinReportService();
        //    var arg = new GetReportIdArrayArg();
        //    arg.DateBegin = new DateTime(2015, 03, 01);
        //    arg.DateEnd = new DateTime(2015, 03, 02);

        //    var result = service.GetReportIdArray(arg);
        //    MessageBox.Show("result.ReportIdArray.Length = " + result.ReportIdArray.Length);
        //}


        //private void webMethodTest_GetReport()
        //{
        //    var service = GetFinReportService();
        //    var arg = new GetReportArg();
        //    arg.ReportID = 45;

        //    var result = service.GetReport(arg);
        //    MessageBox.Show(result.Report.Info);
        //}
    }
}
