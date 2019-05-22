using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN.GUI
{
    public partial class fThongKe : MetroFramework.Forms.MetroForm
    {
        public fThongKe()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
