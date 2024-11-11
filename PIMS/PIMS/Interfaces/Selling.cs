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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();

            timeTimer.Start();

            //To remove header
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            //this.DoubleBuffered = true;

            //
            imgRestore.BringToFront();
            
        }
        //Custom drag bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int tree, int four);

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void imgClose_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult close;
            close = MessageBox.Show("Do you want to Close?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (close == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void imgMaximize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState=FormWindowState.Maximized;
            imgRestore.BringToFront();
        }

        private void imgRestore_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            imgMaximize.BringToFront();
        }

        private void imgMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlHeader_MouseEnter(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.FromArgb(20, 20, 90);
        }

        private void pnlHeader_MouseLeave(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.MidnightBlue;
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDateTimeSale.Text = dateTime.ToString();
        }
    }
}
