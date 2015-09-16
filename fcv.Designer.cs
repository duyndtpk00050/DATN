namespace OrderSoftManager
{
    partial class fcv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fcv));
            this.gbthongtincv = new System.Windows.Forms.GroupBox();
            this.dtgdscv = new System.Windows.Forms.DataGridView();
            this.sttcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttencv = new System.Windows.Forms.TextBox();
            this.lbltencl = new System.Windows.Forms.Label();
            this.gbchucnangcv = new System.Windows.Forms.GroupBox();
            this.btnrefeshcv = new System.Windows.Forms.Button();
            this.btndelcv = new System.Windows.Forms.Button();
            this.btneditcv = new System.Windows.Forms.Button();
            this.btnaddcv = new System.Windows.Forms.Button();
            this.gbthongtincv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdscv)).BeginInit();
            this.gbchucnangcv.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbthongtincv
            // 
            this.gbthongtincv.Controls.Add(this.dtgdscv);
            this.gbthongtincv.Controls.Add(this.txttencv);
            this.gbthongtincv.Controls.Add(this.lbltencl);
            this.gbthongtincv.Location = new System.Drawing.Point(12, 12);
            this.gbthongtincv.Name = "gbthongtincv";
            this.gbthongtincv.Size = new System.Drawing.Size(244, 170);
            this.gbthongtincv.TabIndex = 0;
            this.gbthongtincv.TabStop = false;
            this.gbthongtincv.Text = "Thông tin chức vụ";
            // 
            // dtgdscv
            // 
            this.dtgdscv.AllowUserToResizeRows = false;
            this.dtgdscv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdscv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgdscv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgdscv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgdscv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdscv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgdscv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgdscv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgdscv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttcl,
            this.tencv,
            this.idcv});
            this.dtgdscv.EnableHeadersVisualStyles = false;
            this.dtgdscv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgdscv.Location = new System.Drawing.Point(6, 56);
            this.dtgdscv.Name = "dtgdscv";
            this.dtgdscv.ReadOnly = true;
            this.dtgdscv.RowHeadersVisible = false;
            this.dtgdscv.Size = new System.Drawing.Size(232, 108);
            this.dtgdscv.TabIndex = 1;
            // 
            // sttcl
            // 
            this.sttcl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sttcl.HeaderText = "STT";
            this.sttcl.Name = "sttcl";
            this.sttcl.ReadOnly = true;
            this.sttcl.Width = 53;
            // 
            // tencv
            // 
            this.tencv.HeaderText = "Tên chức vụ";
            this.tencv.Name = "tencv";
            this.tencv.ReadOnly = true;
            this.tencv.Width = 93;
            // 
            // idcv
            // 
            this.idcv.HeaderText = "idcv";
            this.idcv.Name = "idcv";
            this.idcv.ReadOnly = true;
            this.idcv.Visible = false;
            this.idcv.Width = 52;
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(80, 22);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(158, 20);
            this.txttencv.TabIndex = 0;
            // 
            // lbltencl
            // 
            this.lbltencl.AutoSize = true;
            this.lbltencl.Location = new System.Drawing.Point(6, 25);
            this.lbltencl.Name = "lbltencl";
            this.lbltencl.Size = new System.Drawing.Size(68, 13);
            this.lbltencl.TabIndex = 0;
            this.lbltencl.Text = "Tên chức vụ";
            // 
            // gbchucnangcv
            // 
            this.gbchucnangcv.Controls.Add(this.btnrefeshcv);
            this.gbchucnangcv.Controls.Add(this.btndelcv);
            this.gbchucnangcv.Controls.Add(this.btneditcv);
            this.gbchucnangcv.Controls.Add(this.btnaddcv);
            this.gbchucnangcv.Location = new System.Drawing.Point(262, 12);
            this.gbchucnangcv.Name = "gbchucnangcv";
            this.gbchucnangcv.Size = new System.Drawing.Size(115, 170);
            this.gbchucnangcv.TabIndex = 1;
            this.gbchucnangcv.TabStop = false;
            this.gbchucnangcv.Text = "Chức năng";
            // 
            // btnrefeshcv
            // 
            this.btnrefeshcv.BackColor = System.Drawing.Color.White;
            this.btnrefeshcv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefeshcv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnrefeshcv.Location = new System.Drawing.Point(20, 25);
            this.btnrefeshcv.Name = "btnrefeshcv";
            this.btnrefeshcv.Size = new System.Drawing.Size(75, 23);
            this.btnrefeshcv.TabIndex = 0;
            this.btnrefeshcv.Text = "Mới";
            this.btnrefeshcv.UseVisualStyleBackColor = false;
            // 
            // btndelcv
            // 
            this.btndelcv.BackColor = System.Drawing.Color.White;
            this.btndelcv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelcv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndelcv.Location = new System.Drawing.Point(20, 128);
            this.btndelcv.Name = "btndelcv";
            this.btndelcv.Size = new System.Drawing.Size(75, 23);
            this.btndelcv.TabIndex = 3;
            this.btndelcv.Text = "Xóa";
            this.btndelcv.UseVisualStyleBackColor = false;
            // 
            // btneditcv
            // 
            this.btneditcv.BackColor = System.Drawing.Color.White;
            this.btneditcv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditcv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneditcv.Location = new System.Drawing.Point(20, 92);
            this.btneditcv.Name = "btneditcv";
            this.btneditcv.Size = new System.Drawing.Size(75, 23);
            this.btneditcv.TabIndex = 2;
            this.btneditcv.Text = "Sửa";
            this.btneditcv.UseVisualStyleBackColor = false;
            // 
            // btnaddcv
            // 
            this.btnaddcv.BackColor = System.Drawing.Color.White;
            this.btnaddcv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddcv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnaddcv.Location = new System.Drawing.Point(20, 56);
            this.btnaddcv.Name = "btnaddcv";
            this.btnaddcv.Size = new System.Drawing.Size(75, 23);
            this.btnaddcv.TabIndex = 1;
            this.btnaddcv.Text = "Thêm";
            this.btnaddcv.UseVisualStyleBackColor = false;
            // 
            // fcv
            // 
            this.AcceptButton = this.btnrefeshcv;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 193);
            this.Controls.Add(this.gbthongtincv);
            this.Controls.Add(this.gbchucnangcv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fcv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức vụ";
            this.gbthongtincv.ResumeLayout(false);
            this.gbthongtincv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdscv)).EndInit();
            this.gbchucnangcv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbthongtincv;
        private System.Windows.Forms.DataGridView dtgdscv;
        private System.Windows.Forms.TextBox txttencv;
        private System.Windows.Forms.Label lbltencl;
        private System.Windows.Forms.GroupBox gbchucnangcv;
        private System.Windows.Forms.Button btndelcv;
        private System.Windows.Forms.Button btneditcv;
        private System.Windows.Forms.Button btnaddcv;
        private System.Windows.Forms.Button btnrefeshcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcv;
    }
}