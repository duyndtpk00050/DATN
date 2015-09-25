namespace QLBanHang
{
    partial class fcl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fcl));
            this.gbchucnangcl = new System.Windows.Forms.GroupBox();
            this.btnchitietcl = new System.Windows.Forms.Button();
            this.btndelcl = new System.Windows.Forms.Button();
            this.btneditcl = new System.Windows.Forms.Button();
            this.btnaddcl = new System.Windows.Forms.Button();
            this.dtgdscl = new System.Windows.Forms.DataGridView();
            this.sttcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiancl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbthongtincl = new System.Windows.Forms.GroupBox();
            this.txtthoigianlam = new System.Windows.Forms.TextBox();
            this.txttencl = new System.Windows.Forms.TextBox();
            this.lbldaucl = new System.Windows.Forms.Label();
            this.lbltencl = new System.Windows.Forms.Label();
            this.gbchucnangcl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdscl)).BeginInit();
            this.gbthongtincl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbchucnangcl
            // 
            this.gbchucnangcl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbchucnangcl.Controls.Add(this.btnchitietcl);
            this.gbchucnangcl.Controls.Add(this.btndelcl);
            this.gbchucnangcl.Controls.Add(this.btneditcl);
            this.gbchucnangcl.Controls.Add(this.btnaddcl);
            this.gbchucnangcl.Location = new System.Drawing.Point(12, 12);
            this.gbchucnangcl.Name = "gbchucnangcl";
            this.gbchucnangcl.Size = new System.Drawing.Size(363, 69);
            this.gbchucnangcl.TabIndex = 1;
            this.gbchucnangcl.TabStop = false;
            this.gbchucnangcl.Text = "Chức năng";
            // 
            // btnchitietcl
            // 
            this.btnchitietcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchitietcl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnchitietcl.Location = new System.Drawing.Point(278, 27);
            this.btnchitietcl.Name = "btnchitietcl";
            this.btnchitietcl.Size = new System.Drawing.Size(65, 23);
            this.btnchitietcl.TabIndex = 3;
            this.btnchitietcl.Text = "Chi tiết";
            this.btnchitietcl.UseVisualStyleBackColor = true;
            // 
            // btndelcl
            // 
            this.btndelcl.BackColor = System.Drawing.Color.White;
            this.btndelcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelcl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndelcl.Location = new System.Drawing.Point(195, 27);
            this.btndelcl.Name = "btndelcl";
            this.btndelcl.Size = new System.Drawing.Size(65, 23);
            this.btndelcl.TabIndex = 2;
            this.btndelcl.Text = "Xóa";
            this.btndelcl.UseVisualStyleBackColor = false;
            this.btndelcl.Click += new System.EventHandler(this.btndelcl_Click);
            // 
            // btneditcl
            // 
            this.btneditcl.BackColor = System.Drawing.Color.White;
            this.btneditcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditcl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneditcl.Location = new System.Drawing.Point(112, 27);
            this.btneditcl.Name = "btneditcl";
            this.btneditcl.Size = new System.Drawing.Size(65, 23);
            this.btneditcl.TabIndex = 1;
            this.btneditcl.Text = "Sửa";
            this.btneditcl.UseVisualStyleBackColor = false;
            // 
            // btnaddcl
            // 
            this.btnaddcl.BackColor = System.Drawing.Color.White;
            this.btnaddcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddcl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnaddcl.Location = new System.Drawing.Point(19, 27);
            this.btnaddcl.Name = "btnaddcl";
            this.btnaddcl.Size = new System.Drawing.Size(75, 23);
            this.btnaddcl.TabIndex = 0;
            this.btnaddcl.Text = "Thêm mới";
            this.btnaddcl.UseVisualStyleBackColor = false;
            this.btnaddcl.Click += new System.EventHandler(this.btnaddcl_Click);
            // 
            // dtgdscl
            // 
            this.dtgdscl.AllowUserToAddRows = false;
            this.dtgdscl.AllowUserToDeleteRows = false;
            this.dtgdscl.AllowUserToResizeRows = false;
            this.dtgdscl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdscl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgdscl.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgdscl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdscl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgdscl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgdscl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgdscl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttcl,
            this.tencl,
            this.thoigiancl,
            this.idcl});
            this.dtgdscl.EnableHeadersVisualStyles = false;
            this.dtgdscl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgdscl.Location = new System.Drawing.Point(6, 102);
            this.dtgdscl.Name = "dtgdscl";
            this.dtgdscl.ReadOnly = true;
            this.dtgdscl.RowHeadersVisible = false;
            this.dtgdscl.Size = new System.Drawing.Size(351, 156);
            this.dtgdscl.TabIndex = 2;
            // 
            // sttcl
            // 
            this.sttcl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sttcl.HeaderText = "STT";
            this.sttcl.Name = "sttcl";
            this.sttcl.ReadOnly = true;
            this.sttcl.Width = 52;
            // 
            // tencl
            // 
            this.tencl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tencl.DataPropertyName = "tencl";
            this.tencl.HeaderText = "Tên ca";
            this.tencl.Name = "tencl";
            this.tencl.ReadOnly = true;
            this.tencl.Width = 65;
            // 
            // thoigiancl
            // 
            this.thoigiancl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.thoigiancl.DataPropertyName = "thoigiancl";
            this.thoigiancl.HeaderText = "Thời gian ca làm";
            this.thoigiancl.Name = "thoigiancl";
            this.thoigiancl.ReadOnly = true;
            this.thoigiancl.Width = 109;
            // 
            // idcl
            // 
            this.idcl.DataPropertyName = "idcl";
            this.idcl.HeaderText = "idcl";
            this.idcl.Name = "idcl";
            this.idcl.ReadOnly = true;
            this.idcl.Visible = false;
            this.idcl.Width = 47;
            // 
            // gbthongtincl
            // 
            this.gbthongtincl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbthongtincl.Controls.Add(this.txtthoigianlam);
            this.gbthongtincl.Controls.Add(this.dtgdscl);
            this.gbthongtincl.Controls.Add(this.txttencl);
            this.gbthongtincl.Controls.Add(this.lbldaucl);
            this.gbthongtincl.Controls.Add(this.lbltencl);
            this.gbthongtincl.Location = new System.Drawing.Point(12, 87);
            this.gbthongtincl.Name = "gbthongtincl";
            this.gbthongtincl.Size = new System.Drawing.Size(363, 264);
            this.gbthongtincl.TabIndex = 0;
            this.gbthongtincl.TabStop = false;
            this.gbthongtincl.Text = "Thông tin ca làm";
            // 
            // txtthoigianlam
            // 
            this.txtthoigianlam.Location = new System.Drawing.Point(80, 64);
            this.txtthoigianlam.Name = "txtthoigianlam";
            this.txtthoigianlam.Size = new System.Drawing.Size(106, 20);
            this.txtthoigianlam.TabIndex = 1;
            // 
            // txttencl
            // 
            this.txttencl.Location = new System.Drawing.Point(80, 30);
            this.txttencl.Name = "txttencl";
            this.txttencl.Size = new System.Drawing.Size(106, 20);
            this.txttencl.TabIndex = 0;
            // 
            // lbldaucl
            // 
            this.lbldaucl.AutoSize = true;
            this.lbldaucl.Location = new System.Drawing.Point(33, 67);
            this.lbldaucl.Name = "lbldaucl";
            this.lbldaucl.Size = new System.Drawing.Size(34, 13);
            this.lbldaucl.TabIndex = 1;
            this.lbldaucl.Text = "Mô tả";
            // 
            // lbltencl
            // 
            this.lbltencl.AutoSize = true;
            this.lbltencl.Location = new System.Drawing.Point(33, 33);
            this.lbltencl.Name = "lbltencl";
            this.lbltencl.Size = new System.Drawing.Size(41, 13);
            this.lbltencl.TabIndex = 0;
            this.lbltencl.Text = "Tên ca";
            // 
            // fcl
            // 
            this.AcceptButton = this.btnaddcl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 363);
            this.Controls.Add(this.gbthongtincl);
            this.Controls.Add(this.gbchucnangcl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fcl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ca làm việc";
            this.Load += new System.EventHandler(this.fcl_Load);
            this.gbchucnangcl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdscl)).EndInit();
            this.gbthongtincl.ResumeLayout(false);
            this.gbthongtincl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbchucnangcl;
        private System.Windows.Forms.DataGridView dtgdscl;
        private System.Windows.Forms.GroupBox gbthongtincl;
        private System.Windows.Forms.Button btndelcl;
        private System.Windows.Forms.Button btneditcl;
        private System.Windows.Forms.Button btnaddcl;
        private System.Windows.Forms.Button btnchitietcl;
        private System.Windows.Forms.Label lbldaucl;
        private System.Windows.Forms.Label lbltencl;
        private System.Windows.Forms.TextBox txttencl;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencl;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiancl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcl;
        private System.Windows.Forms.TextBox txtthoigianlam;
    }
}