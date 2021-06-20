using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Manager
{
    public partial class FormRP : Form
    {
        public FormRP()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormRP_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QL_CHTLConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Hoadontheongay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Ngayban", dateTimePicker1.Value.Date));
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Baocaohd.rdlc";
            if(ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}
