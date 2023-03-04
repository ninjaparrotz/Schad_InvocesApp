using Schad_InvocesApp.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schad_InvocesApp
{
    public partial class DashApp : Form
    {
        public DashApp()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            customerControl1.BringToFront();
            lblModule.Text = "Clientes";
        }

        private void DashApp_Load(object sender, EventArgs e)
        {
            customerControl1.BringToFront();
            lblModule.Text = "Clientes";
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            invoicesControl1.BringToFront();
            lblModule.Text = "Facturas";
        }

        private void btnCustomerType_Click(object sender, EventArgs e)
        {
            customerTypeControl1.BringToFront();
            lblModule.Text = "Tipo Cliente";
        }
    }
}
