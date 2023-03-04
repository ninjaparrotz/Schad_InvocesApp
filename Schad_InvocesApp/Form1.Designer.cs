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
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblModule = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnCustomerType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerTypeControl1 = new Schad_InvocesApp.userControls.customerTypeControl();
            this.invoicesControl1 = new Schad_InvocesApp.userControls.InvoicesControl();
            this.customerControl1 = new Schad_InvocesApp.userControls.customerControl();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(68)))));
            this.topPanel.Controls.Add(this.lblModule);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(860, 96);
            this.topPanel.TabIndex = 0;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(213, 51);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(92, 25);
            this.lblModule.TabIndex = 1;
            this.lblModule.Text = "Clientes";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(816, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 96);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.btnCustomerType);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.btnInvoices);
            this.leftPanel.Controls.Add(this.btnCustomers);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 96);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(198, 525);
            this.leftPanel.TabIndex = 1;
            // 
            // btnCustomerType
            // 
            this.btnCustomerType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomerType.FlatAppearance.BorderSize = 0;
            this.btnCustomerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCustomerType.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerType.Image")));
            this.btnCustomerType.Location = new System.Drawing.Point(3, 76);
            this.btnCustomerType.Name = "btnCustomerType";
            this.btnCustomerType.Size = new System.Drawing.Size(198, 51);
            this.btnCustomerType.TabIndex = 5;
            this.btnCustomerType.Text = "    Tipo Clientes";
            this.btnCustomerType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerType.UseVisualStyleBackColor = true;
            this.btnCustomerType.Click += new System.EventHandler(this.btnCustomerType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Schad Logistics...";
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInvoices.FlatAppearance.BorderSize = 0;
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnInvoices.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoices.Image")));
            this.btnInvoices.Location = new System.Drawing.Point(3, 133);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(198, 51);
            this.btnInvoices.TabIndex = 3;
            this.btnInvoices.Text = "        Facturas";
            this.btnInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.Location = new System.Drawing.Point(0, 19);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(198, 51);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "         Clientes";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customerTypeControl1);
            this.panel1.Controls.Add(this.invoicesControl1);
            this.panel1.Controls.Add(this.customerControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(198, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 525);
            this.panel1.TabIndex = 2;
            // 
            // customerTypeControl1
            // 
            this.customerTypeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTypeControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.customerTypeControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.customerTypeControl1.Location = new System.Drawing.Point(0, 0);
            this.customerTypeControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerTypeControl1.Name = "customerTypeControl1";
            this.customerTypeControl1.Size = new System.Drawing.Size(662, 525);
            this.customerTypeControl1.TabIndex = 2;
            // 
            // invoicesControl1
            // 
            this.invoicesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoicesControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.invoicesControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.invoicesControl1.Location = new System.Drawing.Point(0, 0);
            this.invoicesControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoicesControl1.Name = "invoicesControl1";
            this.invoicesControl1.Size = new System.Drawing.Size(662, 525);
            this.invoicesControl1.TabIndex = 1;
            // 
            // customerControl1
            // 
            this.customerControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.customerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.customerControl1.Location = new System.Drawing.Point(0, 0);
            this.customerControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerControl1.Name = "customerControl1";
            this.customerControl1.Size = new System.Drawing.Size(662, 525);
            this.customerControl1.TabIndex = 0;
            // 
            // DashApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schad Facturas";
            this.Load += new System.EventHandler(this.DashApp_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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

