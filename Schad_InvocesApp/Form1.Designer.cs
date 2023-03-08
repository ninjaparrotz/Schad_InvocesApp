namespace Schad_InvocesApp
{
    partial class DashApp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashApp));
            topPanel = new System.Windows.Forms.Panel();
            lblModule = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            leftPanel = new System.Windows.Forms.Panel();
            btnCustomerType = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnInvoices = new System.Windows.Forms.Button();
            btnCustomers = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            customerTypeControl1 = new userControls.customerTypeControl();
            invoicesControl1 = new userControls.InvoicesControl();
            customerControl1 = new userControls.customerControl();
            topPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.FromArgb(0, 33, 68);
            topPanel.Controls.Add(lblModule);
            topPanel.Controls.Add(btnClose);
            topPanel.Controls.Add(panel2);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1003, 111);
            topPanel.TabIndex = 0;
            // 
            // lblModule
            // 
            lblModule.AutoSize = true;
            lblModule.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblModule.ForeColor = System.Drawing.Color.White;
            lblModule.Location = new System.Drawing.Point(248, 59);
            lblModule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblModule.Name = "lblModule";
            lblModule.Size = new System.Drawing.Size(92, 25);
            lblModule.TabIndex = 1;
            lblModule.Text = "Clientes";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(952, 12);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(48, 40);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(192, 111);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(231, 111);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = System.Drawing.Color.White;
            leftPanel.Controls.Add(btnCustomerType);
            leftPanel.Controls.Add(label1);
            leftPanel.Controls.Add(btnInvoices);
            leftPanel.Controls.Add(btnCustomers);
            leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            leftPanel.Location = new System.Drawing.Point(0, 111);
            leftPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new System.Drawing.Size(231, 606);
            leftPanel.TabIndex = 1;
            // 
            // btnCustomerType
            // 
            btnCustomerType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCustomerType.FlatAppearance.BorderSize = 0;
            btnCustomerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCustomerType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCustomerType.ForeColor = System.Drawing.Color.MidnightBlue;
            btnCustomerType.Image = (System.Drawing.Image)resources.GetObject("btnCustomerType.Image");
            btnCustomerType.Location = new System.Drawing.Point(4, 88);
            btnCustomerType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCustomerType.Name = "btnCustomerType";
            btnCustomerType.Size = new System.Drawing.Size(231, 59);
            btnCustomerType.TabIndex = 5;
            btnCustomerType.Text = "    Tipo Clientes";
            btnCustomerType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCustomerType.UseVisualStyleBackColor = true;
            btnCustomerType.Click += btnCustomerType_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 580);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 15);
            label1.TabIndex = 4;
            label1.Text = "Schad Logistics...";
            // 
            // btnInvoices
            // 
            btnInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnInvoices.FlatAppearance.BorderSize = 0;
            btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInvoices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnInvoices.ForeColor = System.Drawing.Color.MidnightBlue;
            btnInvoices.Image = (System.Drawing.Image)resources.GetObject("btnInvoices.Image");
            btnInvoices.Location = new System.Drawing.Point(4, 153);
            btnInvoices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new System.Drawing.Size(231, 59);
            btnInvoices.TabIndex = 3;
            btnInvoices.Text = "        Facturas";
            btnInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnInvoices.UseVisualStyleBackColor = true;
            btnInvoices.Click += btnInvoices_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCustomers.ForeColor = System.Drawing.Color.MidnightBlue;
            btnCustomers.Image = (System.Drawing.Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.Location = new System.Drawing.Point(0, 22);
            btnCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new System.Drawing.Size(231, 59);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "         Clientes";
            btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(customerTypeControl1);
            panel1.Controls.Add(invoicesControl1);
            panel1.Controls.Add(customerControl1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(231, 111);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(772, 606);
            panel1.TabIndex = 2;
            // 
            // customerTypeControl1
            // 
            customerTypeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            customerTypeControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            customerTypeControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            customerTypeControl1.Location = new System.Drawing.Point(0, 0);
            customerTypeControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            customerTypeControl1.Name = "customerTypeControl1";
            customerTypeControl1.Size = new System.Drawing.Size(772, 606);
            customerTypeControl1.TabIndex = 2;
            // 
            // invoicesControl1
            // 
            invoicesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            invoicesControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            invoicesControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            invoicesControl1.Location = new System.Drawing.Point(0, 0);
            invoicesControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            invoicesControl1.Name = "invoicesControl1";
            invoicesControl1.Size = new System.Drawing.Size(772, 606);
            invoicesControl1.TabIndex = 1;
            // 
            // customerControl1
            // 
            customerControl1.BackColor = System.Drawing.Color.Gainsboro;
            customerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            customerControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            customerControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            customerControl1.Location = new System.Drawing.Point(0, 0);
            customerControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            customerControl1.Name = "customerControl1";
            customerControl1.Size = new System.Drawing.Size(772, 606);
            customerControl1.TabIndex = 0;
            // 
            // DashApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1003, 717);
            Controls.Add(panel1);
            Controls.Add(leftPanel);
            Controls.Add(topPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "DashApp";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Schad Facturas";
            Load += DashApp_Load;
            Shown += DashApp_Shown;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private userControls.customerControl customerControl1;
        private System.Windows.Forms.Label lblModule;
        private userControls.InvoicesControl invoicesControl1;
        private System.Windows.Forms.Button btnCustomerType;
        private userControls.customerTypeControl customerTypeControl1;
    }
}

