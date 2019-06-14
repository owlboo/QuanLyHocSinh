using QLHS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmQuydinhdotuoi : Form
    {
        public frmQuydinhdotuoi()
        {
            InitializeComponent();
            lblDuoitoida.Text = QuidinhtuoiDAO.Instance.GetAgeMaxByMaTruong();
            lblDotuoitoithieu.Text = QuidinhtuoiDAO.Instance.GetAgeMinByMaTruong();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDotuoitoithieu_Click(object sender, EventArgs e)
        {

        }
    }
}
