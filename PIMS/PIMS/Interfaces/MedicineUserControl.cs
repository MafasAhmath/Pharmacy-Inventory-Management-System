using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Interfaces
{
    public partial class MedicineUserControl : UserControl
    {
        public MedicineUserControl()
        {
            InitializeComponent();

            cmbBrand.SelectedIndex = 0;
            cmbCategoty.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;            
        }

        private void btnNewMedi_Click(object sender, EventArgs e)
        {
            NewMedicineForm newMedicineForm = new NewMedicineForm();
            newMedicineForm.Show();
        }

        private void btnAddQty_Click(object sender, EventArgs e)
        {
            AddQtyForm addQtyForm = new AddQtyForm();
            addQtyForm.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbBrand.SelectedIndex = 0;
            cmbCategoty.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
        }
    }
}
