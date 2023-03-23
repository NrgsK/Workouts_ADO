namespace frmOrders01
{
    partial class frmOrders
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
            this.grpboxOrders = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblShipper = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cboxShipVia = new System.Windows.Forms.ComboBox();
            this.cboxEmployee = new System.Windows.Forms.ComboBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpboxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxOrders
            // 
            this.grpboxOrders.BackColor = System.Drawing.Color.LightCyan;
            this.grpboxOrders.Controls.Add(this.btnQuery);
            this.grpboxOrders.Controls.Add(this.lblShipper);
            this.grpboxOrders.Controls.Add(this.lblEmployee);
            this.grpboxOrders.Controls.Add(this.cboxShipVia);
            this.grpboxOrders.Controls.Add(this.cboxEmployee);
            this.grpboxOrders.Controls.Add(this.dgvOrders);
            this.grpboxOrders.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxOrders.Location = new System.Drawing.Point(57, 42);
            this.grpboxOrders.Name = "grpboxOrders";
            this.grpboxOrders.Size = new System.Drawing.Size(1209, 495);
            this.grpboxOrders.TabIndex = 0;
            this.grpboxOrders.TabStop = false;
            this.grpboxOrders.Text = "Orders";
            this.grpboxOrders.AutoSizeChanged += new System.EventHandler(this.grpboxOrders_AutoSizeChanged);
            this.grpboxOrders.SizeChanged += new System.EventHandler(this.frmOrders_Load);
            this.grpboxOrders.Resize += new System.EventHandler(this.frmOrders_Load);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnQuery.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuery.Location = new System.Drawing.Point(214, 122);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(82, 39);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "Sorgula";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblShipper
            // 
            this.lblShipper.AutoSize = true;
            this.lblShipper.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipper.Location = new System.Drawing.Point(38, 94);
            this.lblShipper.Name = "lblShipper";
            this.lblShipper.Size = new System.Drawing.Size(71, 17);
            this.lblShipper.TabIndex = 4;
            this.lblShipper.Text = "Shipper";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(35, 48);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(89, 17);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee ";
            // 
            // cboxShipVia
            // 
            this.cboxShipVia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxShipVia.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxShipVia.FormattingEnabled = true;
            this.cboxShipVia.Location = new System.Drawing.Point(160, 91);
            this.cboxShipVia.Name = "cboxShipVia";
            this.cboxShipVia.Size = new System.Drawing.Size(242, 25);
            this.cboxShipVia.TabIndex = 2;
            // 
            // cboxEmployee
            // 
            this.cboxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEmployee.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEmployee.FormattingEnabled = true;
            this.cboxEmployee.Location = new System.Drawing.Point(157, 45);
            this.cboxEmployee.Name = "cboxEmployee";
            this.cboxEmployee.Size = new System.Drawing.Size(245, 25);
            this.cboxEmployee.TabIndex = 1;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(6, 184);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1197, 305);
            this.dgvOrders.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(1170, 542);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Kapat";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 588);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpboxOrders);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Form";
            this.AutoSizeChanged += new System.EventHandler(this.frmOrders_AutoSizeChanged);
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.grpboxOrders.ResumeLayout(false);
            this.grpboxOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxOrders;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblShipper;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cboxShipVia;
        private System.Windows.Forms.ComboBox cboxEmployee;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnExit;
    }
}

