using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Threading;
using System.Net.Sockets;
using WindowsFormsApplication1.ServiceReference1;


namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {
        private WindowsFormsApplication1.ServiceReference1.FinReportServiceSoapClient wdw = new WindowsFormsApplication1.ServiceReference1.FinReportServiceSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void wad()
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = wdw.My_timeZone();
            //ServiceReference1.FinReport MathServiceClass = new ServiceReference1.FinReport();
            //// Create instances of the operands and result.

            //// Parse the contents of the text boxes into integers.
            //string x = textBox1.Text;



            //// Call the WebAdd Web service method from the instance of the Web service.
            //int z = MathServiceClass.ReportID(x);
            //textBox2.Text = z.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
