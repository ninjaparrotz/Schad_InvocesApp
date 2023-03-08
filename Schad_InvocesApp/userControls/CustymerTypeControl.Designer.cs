namespace Schad_InvocesApp.userControls
{
    partial class customerTypeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerTypeControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblDescVal = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.RichTextBox();
            label4 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            dgvCustomerTypes = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(components);
            btnClear = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerTypes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDescVal);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new System.Drawing.Point(28, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(249, 196);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lblDescVal
            // 
            lblDescVal.AutoSize = true;
            lblDescVal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDescVal.ForeColor = System.Drawing.Color.Crimson;
            lblDescVal.Location = new System.Drawing.Point(227, 22);
            lblDescVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDescVal.Name = "lblDescVal";
            lblDescVal.Size = new System.Drawing.Size(19, 22);
            lblDescVal.TabIndex = 14;
            lblDescVal.Text = "*";
            lblDescVal.Visible = false;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtDescription.Location = new System.Drawing.Point(7, 45);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(236, 145);
            txtDescription.TabIndex = 13;
            txtDescription.Text = "";
            txtDescription.KeyDown += txtDescription_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 22);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 20);
            label4.TabIndex = 12;
            label4.Text = "Descripcion:";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvCustomerTypes);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(307, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(333, 507);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(333, 45);
            panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Image = (System.Drawing.Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new System.Drawing.Point(302, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(28, 26);
            btnDelete.TabIndex = 16;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCustomerTypes
            // 
            dgvCustomerTypes.AllowUserToAddRows = false;
            dgvCustomerTypes.AllowUserToDeleteRows = false;
            dgvCustomerTypes.AllowUserToResizeColumns = false;
            dgvCustomerTypes.AllowUserToResizeRows = false;
            dgvCustomerTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomerTypes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 33, 68);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCustomerTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomerTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Description });
            dgvCustomerTypes.EnableHeadersVisualStyles = false;
            dgvCustomerTypes.Location = new System.Drawing.Point(3, 51);
            dgvCustomerTypes.Name = "dgvCustomerTypes";
            dgvCustomerTypes.ReadOnly = true;
            dgvCustomerTypes.RowHeadersVisible = false;
            dgvCustomerTypes.Size = new System.Drawing.Size(327, 453);
            dgvCustomerTypes.TabIndex = 0;
            dgvCustomerTypes.CellMouseDoubleClick += dgvCustomerTypes_CellMouseDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Descripcion";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.Location = new System.Drawing.Point(35, 243);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(111, 45);
            btnClear.TabIndex = 14;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(164, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(107, 45);
            btnSave.TabIndex = 15;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // customerTypeControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.MidnightBlue;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "customerTypeControl";
            Size = new System.Drawing.Size(640, 507);
            Load += customerTypeControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomerTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomerTypes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDescVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
