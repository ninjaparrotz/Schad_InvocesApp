using Schad_InvocesApp.app;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schad_InvocesApp.userControls
{
    public partial class customerTypeControl : UserControl
    {
        public customerTypeControl()
        {
            InitializeComponent();
        }
        private int SelectedId { get; set; }
        private bool Flag = false;

        private void SaveCustomerT()
        {
            if (txtDescription.Text == string.Empty)
            {
                lblDescVal.Visible = true;
                txtDescription.Focus();

                return;
            }


            if (Flag)
            {
                CustomerType _ct = new CustomerType(SelectedId, txtDescription.Text);
                _ct.Update();
            }
            else
            {
                CustomerType _ct = new CustomerType(txtDescription.Text);
                _ct.Create();
            }

            txtDescription.Text = string.Empty;
            dgvCustomerTypes.DataSource = CustomerType.GetAll();
            SelectedId = 0;
            if (SelectedId == 0)
            {
                btnSave.Text = "Guardar";
                btnDelete.Enabled = false;
                Flag = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.ResetText();
        }

        private void customerTypeControl_Load(object sender, EventArgs e)
        {

            dgvCustomerTypes.DataSource = CustomerType.GetAll();
            EntityConection._Dbcontext = null;
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SaveCustomerT();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveCustomerT();
        }

        private void dgvCustomerTypes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedId = Convert.ToInt32(dgvCustomerTypes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDescription.Text = dgvCustomerTypes.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (SelectedId != 0)
            {
                btnSave.Text = "Actualizar";
                btnDelete.Enabled = true;
                Flag = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedId != 0)
            {
                CustomerType _ct = CustomerType.GetInstance();
                _ct.Id = SelectedId;
                _ct.Delete();
                btnSave.Text = "Guardar";
                dgvCustomerTypes.DataSource = CustomerType.GetAll();
                SelectedId = 0;
                btnDelete.Enabled = false;
                txtDescription.ResetText();
                EntityConection._Dbcontext = null;
            }
        }
    }
}
