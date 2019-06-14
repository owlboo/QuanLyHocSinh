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
    public partial class frmKhoilop : Form
    {
        #region contructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmKhoilop()
        {
            InitializeComponent();
            dGVKhoilop.DataSource = bd;
        }
        #region Event
        private void frmKhoilop_Load(object sender, EventArgs e)
        {
            bd.DataSource = KhoiLopDAO.Instance.LoadKhoiLop();
        }
        #endregion

        #region Func
        #endregion


    }
}
