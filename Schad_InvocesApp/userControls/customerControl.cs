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
    public partial class customerControl : UserControl
    {
        public customerControl()
        {
            InitializeComponent();
        }

        private int SelectedId { get; set; }
        private bool Flag = false;
        private void SaveCustomer()
        {
            if (txtCustomerName.Text == string.Empty)
            {
                lblNameVal.Visible = true;
                txtCustomerName.Focus();

                return;
            }
            if (txtCustomerAddress.Text == string.Empty)
            {
                lblAddressVal.Visible = true;
                txtCustomerAddress.Focus();

                return;
            }

            Customer _c = new Customer(SelectedId,
                txtCustomerName.Text,
                txtCustomerAddress.Text,
                chbCustomerActive.Checked,
                CustomerType.GetInstance(Convert.ToInt32(cmbCustomerType.SelectedValue),
                cmbCustomerType.Text));

            if (Flag)
            {
                _c.Update();
            }
            else
            {
                _c.Create();
            }

            txtCustomerName.ResetText();
            txtCustomerAddress.ResetText();
            cmbCustomerType.SelectedIndex = 0;
            dgvCustomers.DataSource = Customer.GetAll();

            SelectedId = 0;
            btnDelete.Enabled = false;
            btnSave.Text = "Guardar";
            Flag = false;
        }
        private void LoadComponents()
        {
            try
            {
                dgvCustomers.DataSource = Customer.GetAll();
                cmbCustomerType.DataSource = EntityConection.getNewInstance().CustomerTypes.ToList();
                cmbCustomerType.DisplayMember = "Description";
                cmbCustomerType.ValueMember = "Id";
            }
            catch (Exception ex)
            {

            }
        }

        private void customerControl_Load(object sender, EventArgs e)
        {
            LoadComponents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedId != 0)
            {
                Customer _c = new Customer(SelectedId,
                txtCustomerName.Text,
                txtCustomerAddress.Text,
                chbCustomerActive.Checked,
                CustomerType.GetInstance(Convert.ToInt32(cmbCustomerType.SelectedValue),
                cmbCustomerType.Text));
                _c.Id = SelectedId;
                _c.Delete();
                dgvCustomers.DataSource = Customer.GetAll();
                SelectedId = 0;
                btnDelete.Enabled = false;
                txtCustomerName.ResetText();
                txtCustomerAddress.ResetText();
                cmbCustomerType.SelectedIndex = 0;
                EntityConection._Dbcontext = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedId = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCustomerName.Text = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCustomerAddress.Text = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (SelectedId != 0)
            {
                btnDelete.Enabled = true;
                btnSave.Text = "Actualizar";
                Flag = true;
            }
        }
    }
}
