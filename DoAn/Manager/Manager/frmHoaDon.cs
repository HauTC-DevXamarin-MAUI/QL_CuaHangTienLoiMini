using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void loadDGV()
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                var hoadon = from hd in db.HOADONs
                             select new { hd.MAHD, hd.MAKH, hd.MANV, hd.NGAYBAN, hd.TAMTINH, hd.THANHTOAN, hd.GIAMGIA };
                dgv_ChiTietHang.DataSource = hoadon;
            }
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

       
    }
}
