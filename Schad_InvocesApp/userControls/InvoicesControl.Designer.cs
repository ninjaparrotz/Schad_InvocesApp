namespace Schad_InvocesApp.userControls
{
    partial class InvoicesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            dgvInvoices = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalItbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            InvoiceDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel2 = new System.Windows.Forms.Panel();
            lblItbis = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            lblSubTotal = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cmbCantidad = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtItbs = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cmbCustomers = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            btnCreate = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvInvoices);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 257);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(786, 307);
            panel1.TabIndex = 0;
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.AllowUserToResizeColumns = false;
            dgvInvoices.AllowUserToResizeRows = false;
            dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 33, 68);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, CustName, qty, TotalItbis, TotalSubTotal, Total, InvoiceDgv });
            dgvInvoices.EnableHeadersVisualStyles = false;
            dgvInvoices.Location = new System.Drawing.Point(36, 17);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new System.Drawing.Size(703, 267);
            dgvInvoices.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "ID";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // CustName
            // 
            CustName.DataPropertyName = "Customer";
            CustName.HeaderText = "Cliente";
            CustName.Name = "CustName";
            CustName.ReadOnly = true;
            // 
            // qty
            // 
            qty.DataPropertyName = "Qty";
            qty.HeaderText = "Cantidad";
            qty.Name = "qty";
            qty.ReadOnly = true;
            // 
            // TotalItbis
            // 
            TotalItbis.DataPropertyName = "TotalItbis";
            TotalItbis.HeaderText = "Itbis";
            TotalItbis.Name = "TotalItbis";
            TotalItbis.ReadOnly = true;
            // 
            // TotalSubTotal
            // 
            TotalSubTotal.DataPropertyName = "TotalSub";
            TotalSubTotal.HeaderText = "Sub. Total";
            TotalSubTotal.Name = "TotalSubTotal";
            TotalSubTotal.ReadOnly = true;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // InvoiceDgv
            // 
            InvoiceDgv.DataPropertyName = "Invoice";
            InvoiceDgv.HeaderText = "Invoice";
            InvoiceDgv.Name = "InvoiceDgv";
            InvoiceDgv.ReadOnly = true;
            InvoiceDgv.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(cmbCantidad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtItbs);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCustomers);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(36, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(587, 224);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblItbis);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblSubTotal);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new System.Drawing.Point(281, 144);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(268, 73);
            panel2.TabIndex = 16;
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new System.Drawing.Point(100, 40);
            lblItbis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new System.Drawing.Size(14, 20);
            lblItbis.TabIndex = 19;
            lblItbis.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(100, 12);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(40, 20);
            label10.TabIndex = 18;
            label10.Text = "ITBIS";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotal.Location = new System.Drawing.Point(193, 40);
            lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(18, 23);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "-";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new System.Drawing.Point(14, 40);
            lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new System.Drawing.Size(14, 20);
            lblSubTotal.TabIndex = 16;
            lblSubTotal.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(202, 12);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(50, 20);
            label8.TabIndex = 15;
            label8.Text = "TOTAL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(14, 12);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(68, 20);
            label7.TabIndex = 15;
            label7.Text = "SubTotal";
            // 
            // cmbCantidad
            // 
            cmbCantidad.FormattingEnabled = true;
            cmbCantidad.Location = new System.Drawing.Point(136, 104);
            cmbCantidad.Name = "cmbCantidad";
            cmbCantidad.Size = new System.Drawing.Size(195, 28);
            cmbCantidad.TabIndex = 14;
            cmbCantidad.SelectedIndexChanged += cmbCantidad_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(38, 150);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 20);
            label6.TabIndex = 12;
            label6.Text = "Itbis %";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(352, 108);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 20);
            label5.TabIndex = 12;
            label5.Text = "Precio:";
            // 
            // txtItbs
            // 
            txtItbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtItbs.Location = new System.Drawing.Point(136, 150);
            txtItbs.Name = "txtItbs";
            txtItbs.Size = new System.Drawing.Size(121, 26);
            txtItbs.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(38, 108);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 20);
            label4.TabIndex = 12;
            label4.Text = "Cantidad:";
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPrice.Location = new System.Drawing.Point(422, 106);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(127, 26);
            txtPrice.TabIndex = 13;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(132, 22);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(14, 20);
            label3.TabIndex = 11;
            label3.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(38, 22);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 20);
            label1.TabIndex = 10;
            label1.Text = "Factura #:";
            // 
            // cmbCustomers
            // 
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new System.Drawing.Point(136, 64);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new System.Drawing.Size(413, 28);
            cmbCustomers.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 67);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 20);
            label2.TabIndex = 8;
            label2.Text = "Cliente:";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.Color.MediumSeaGreen;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreate.ForeColor = System.Drawing.Color.White;
            btnCreate.Location = new System.Drawing.Point(664, 13);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(75, 45);
            btnCreate.TabIndex = 16;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // InvoicesControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnCreate);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.MidnightBlue;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "InvoicesControl";
            Size = new System.Drawing.Size(786, 564);
            Load += InvoicesControl_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItbs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDgv;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label label10;
    }
}
