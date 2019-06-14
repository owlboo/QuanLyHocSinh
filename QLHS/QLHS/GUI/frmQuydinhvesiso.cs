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
    public partial class frmQuydinhvesiso : Form
    {
        public frmQuydinhvesiso()
        {
            InitializeComponent();
            lblSisotoida.Text = QuyDinhSiSoDAO.Instance.GetSiSoMaxByMaTruong();
            lblSisotoithieu.Text = QuyDinhSiSoDAO.Instance.GetSiSoMinByMaTruong();
        }

        private void frmQuydinhvesiso_Load(object sender, EventArgs e)
        {

        }
    }
}
