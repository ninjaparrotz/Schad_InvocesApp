namespace Schad_InvocesApp.userControls
{
    partial class customerControl
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            label2 = new System.Windows.Forms.Label();
            panelGrid = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            dgvCustomers = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustomerType_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtCustomerAddress = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cmbCustomerType = new System.Windows.Forms.ComboBox();
            schadInvocesEntitiesBindingSource1 = new System.Windows.Forms.BindingSource(components);
            customerTypeBindingSource1 = new System.Windows.Forms.BindingSource(components);
            schadInvocesEntitiesBindingSource = new System.Windows.Forms.BindingSource(components);
            customerTypeBindingSource = new System.Windows.Forms.BindingSource(components);
            chbCustomerActive = new System.Windows.Forms.CheckBox();
            btnSave = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblAddressVal = new System.Windows.Forms.Label();
            lblNameVal = new System.Windows.Forms.Label();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schadInvocesEntitiesBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerTypeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schadInvocesEntitiesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerTypeBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 47);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(btnDelete);
            panelGrid.Controls.Add(dgvCustomers);
            panelGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelGrid.Location = new System.Drawing.Point(0, 195);
            panelGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new System.Drawing.Size(733, 312);
            panelGrid.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.Tomato;
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(625, 241);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 45);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 33, 68);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Name, Address, CustomerType_Id, Status });
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.Location = new System.Drawing.Point(36, 3);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new System.Drawing.Size(664, 218);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Nombre";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Direccion";
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // CustomerType_Id
            // 
            CustomerType_Id.DataPropertyName = "Customer_Type";
            CustomerType_Id.HeaderText = "Tipo Cliente";
            CustomerType_Id.Name = "CustomerType_Id";
            CustomerType_Id.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Estado";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCustomerName.Location = new System.Drawing.Point(132, 47);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(399, 26);
            txtCustomerName.TabIndex = 7;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCustomerAddress.Location = new System.Drawing.Point(132, 91);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new System.Drawing.Size(399, 26);
            txtCustomerAddress.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 91);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 20);
            label1.TabIndex = 8;
            label1.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 133);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 20);
            label3.TabIndex = 10;
            label3.Text = "Tipo Cliente:";
            // 
            // cmbCustomerType
            // 
            cmbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCustomerType.FormattingEnabled = true;
            cmbCustomerType.Location = new System.Drawing.Point(132, 133);
            cmbCustomerType.Name = "cmbCustomerType";
            cmbCustomerType.Size = new System.Drawing.Size(225, 28);
            cmbCustomerType.TabIndex = 1;
            // 
            // schadInvocesEntitiesBindingSource1
            // 
            schadInvocesEntitiesBindingSource1.DataSource = typeof(DbContext.schad_InvocesEntities);
            // 
            // customerTypeBindingSource1
            // 
            customerTypeBindingSource1.DataSource = typeof(DbContext.CustomerType);
            // 
            // schadInvocesEntitiesBindingSource
            // 
            schadInvocesEntitiesBindingSource.DataSource = typeof(DbContext.schad_InvocesEntities);
            // 
            // customerTypeBindingSource
            // 
            customerTypeBindingSource.DataSource = typeof(DbContext.CustomerType);
            // 
            // chbCustomerActive
            // 
            chbCustomerActive.AutoSize = true;
            chbCustomerActive.Checked = true;
            chbCustomerActive.CheckState = System.Windows.Forms.CheckState.Checked;
            chbCustomerActive.Location = new System.Drawing.Point(454, 132);
            chbCustomerActive.Name = "chbCustomerActive";
            chbCustomerActive.Size = new System.Drawing.Size(77, 24);
            chbCustomerActive.TabIndex = 12;
            chbCustomerActive.Text = "Activo";
            chbCustomerActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(614, 50);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(98, 45);
            btnSave.TabIndex = 13;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.Location = new System.Drawing.Point(614, 111);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(98, 45);
            btnClear.TabIndex = 13;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAddressVal);
            groupBox1.Controls.Add(lblNameVal);
            groupBox1.Controls.Add(txtCustomerAddress);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(chbCustomerActive);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCustomerType);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new System.Drawing.Point(21, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(558, 174);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // lblAddressVal
            // 
            lblAddressVal.AutoSize = true;
            lblAddressVal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAddressVal.ForeColor = System.Drawing.Color.Crimson;
            lblAddressVal.Location = new System.Drawing.Point(532, 95);
            lblAddressVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAddressVal.Name = "lblAddressVal";
            lblAddressVal.Size = new System.Drawing.Size(19, 22);
            lblAddressVal.TabIndex = 16;
            lblAddressVal.Text = "*";
            lblAddressVal.Visible = false;
            // 
            // lblNameVal
            // 
            lblNameVal.AutoSize = true;
            lblNameVal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNameVal.ForeColor = System.Drawing.Color.Crimson;
            lblNameVal.Location = new System.Drawing.Point(532, 51);
            lblNameVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNameVal.Name = "lblNameVal";
            lblNameVal.Size = new System.Drawing.Size(19, 22);
            lblNameVal.TabIndex = 15;
            lblNameVal.Text = "*";
            lblNameVal.Visible = false;
            // 
            // customerControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(panelGrid);
            Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.MidnightBlue;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Size = new System.Drawing.Size(733, 507);
            Load += customerControl_Load;
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)schadInvocesEntitiesBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerTypeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)schadInvocesEntitiesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerTypeBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.CheckBox chbCustomerActive;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddressVal;
        private System.Windows.Forms.Label lblNameVal;
        private System.Windows.Forms.BindingSource customerTypeBindingSource;
        private System.Windows.Forms.BindingSource customerTypeBindingSource1;
        private System.Windows.Forms.BindingSource schadInvocesEntitiesBindingSource;
        private System.Windows.Forms.BindingSource schadInvocesEntitiesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
