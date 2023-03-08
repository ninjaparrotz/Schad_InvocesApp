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
    public partial class InvoicesControl : UserControl
    {
        public InvoicesControl()
        {
            InitializeComponent();
        }
        private void LoadComponents()
        {
            try
            {
                cmbCustomers.DataSource = Customer.GetAllList();
                cmbCustomers.DisplayMember = "CustName";
                cmbCustomers.ValueMember = "Id";
                for (int i = 1; i < 100; i++)
                {
                    cmbCantidad.Items.Add(i.ToString());
                }
                cmbCantidad.SelectedIndex = 0;
                txtItbs.Text = "18";
                txtPrice.Text = "0";
                dgvInvoices.DataSource = Invoice.GetAll();
            }
            catch (Exception ex)
            {

            }
        }
        private void InvoicesControl_Load(object sender, EventArgs e)
        {
            LoadComponents();
        }
        private void Save()
        {
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(cmbCustomers.SelectedValue.ToString());
            customer.Name = cmbCustomers.Text;
            Invoice.Build(0, customer, Convert.ToInt32(cmbCantidad.Text), Convert.ToDecimal(txtPrice.Text),
            Convert.ToDecimal(txtItbs.Text), Convert.ToDecimal(lblSubTotal.Text), Convert.ToDecimal(lblTotal.Text));
            dgvInvoices.DataSource = Customer.GetAllList();
        }
        private void Calc()
        {
            if (txtPrice.Text.Length > 0 && cmbCantidad.Text != string.Empty)
            {
                lblSubTotal.Text = (Convert.ToInt32(cmbCantidad.Text) * Convert.ToDecimal(txtPrice.Text)).ToString("N2");
                lblItbis.Text = (((Convert.ToDecimal(txtPrice.Text) / 100) / Convert.ToDecimal(txtItbs.Text)) * 100).ToString("N2");
                lblTotal.Text = (Convert.ToDecimal(lblSubTotal.Text) + Convert.ToDecimal(lblItbis.Text)).ToString("N2");
            }
            else
            {
                lblSubTotal.Text = "-";
                lblTotal.Text = "-";
                lblItbis.Text = "-";
            }
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Save();
            dgvInvoices.DataSource = Invoice.GetAll();
        }

        private void cmbCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc();
        }
    }
}
