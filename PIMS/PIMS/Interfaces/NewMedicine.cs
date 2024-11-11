using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Interfaces
{
    public partial class NewMedicineForm : Form
    {
        public NewMedicineForm()
        {
            InitializeComponent();

            //To remove header
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;

            


        }
        //Custom drag bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int tree, int four);

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_MouseEnter(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.FromArgb(20, 20, 90);
        }

        private void pnlHeader_MouseLeave(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.MidnightBlue;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void imgMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            txtItemCode.Clear();
            txtItemSize.Clear();
            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
            txtBarcode.Clear();
            txtOthers.Clear();
            txtQty.Clear();
            txtTOtalQty.Clear();
            txtPrchsPrc.Clear();
            txtMiniPrc.Clear();
            txtSellPrc.Clear();
            txtDiscount.Clear();
        }
    }
}
