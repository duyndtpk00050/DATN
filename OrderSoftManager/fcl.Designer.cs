namespace OrderSoftManager
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
            this.dtpcuoicl = new System.Windows.Forms.DateTimePicker();
            this.dtpdaucl = new System.Windows.Forms.DateTimePicker();
            this.txttencl = new System.Windows.Forms.TextBox();
            this.lblcuoicl = new System.Windows.Forms.Label();
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
            // 
            // dtgdscl
            // 
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
            this.dtgdscl.Size = new System.Drawing.Size(351, 140);
            this.dtgdscl.TabIndex = 3;
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
            this.tencl.HeaderText = "Tên ca";
            this.tencl.Name = "tencl";
            this.tencl.ReadOnly = true;
            this.tencl.Width = 65;
            // 
            // thoigiancl
            // 
            this.thoigiancl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.thoigiancl.HeaderText = "Thời gian ca làm";
            this.thoigiancl.Name = "thoigiancl";
            this.thoigiancl.ReadOnly = true;
            this.thoigiancl.Width = 109;
            // 
            // idcl
            // 
            this.idcl.HeaderText = "idcl";
            this.idcl.Name = "idcl";
            this.idcl.ReadOnly = true;
            this.idcl.Visible = false;
            this.idcl.Width = 48;
            // 
            // gbthongtincl
            // 
            this.gbthongtincl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbthongtincl.Controls.Add(this.dtpcuoicl);
            this.gbthongtincl.Controls.Add(this.dtgdscl);
            this.gbthongtincl.Controls.Add(this.dtpdaucl);
            this.gbthongtincl.Controls.Add(this.txttencl);
            this.gbthongtincl.Controls.Add(this.lblcuoicl);
            this.gbthongtincl.Controls.Add(this.lbldaucl);
            this.gbthongtincl.Controls.Add(this.lbltencl);
            this.gbthongtincl.Location = new System.Drawing.Point(12, 87);
            this.gbthongtincl.Name = "gbthongtincl";
            this.gbthongtincl.Size = new System.Drawing.Size(363, 248);
            this.gbthongtincl.TabIndex = 0;
            this.gbthongtincl.TabStop = false;
            this.gbthongtincl.Text = "Thông tin ca làm";
            // 
            // dtpcuoicl
            // 
            this.dtpcuoicl.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpcuoicl.Location = new System.Drawing.Point(264, 63);
            this.dtpcuoicl.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpcuoicl.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpcuoicl.Name = "dtpcuoicl";
            this.dtpcuoicl.ShowUpDown = true;
            this.dtpcuoicl.Size = new System.Drawing.Size(81, 20);
            this.dtpcuoicl.TabIndex = 2;
            this.dtpcuoicl.Value = new System.DateTime(2015, 9, 13, 19, 8, 17, 0);
            // 
            // dtpdaucl
            // 
            this.dtpdaucl.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpdaucl.Location = new System.Drawing.Point(85, 63);
            this.dtpdaucl.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpdaucl.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpdaucl.Name = "dtpdaucl";
            this.dtpdaucl.ShowUpDown = true;
            this.dtpdaucl.Size = new System.Drawing.Size(91, 20);
            this.dtpdaucl.TabIndex = 1;
            this.dtpdaucl.Value = new System.DateTime(2015, 9, 13, 19, 8, 17, 0);
            // 
            // txttencl
            // 
            this.txttencl.Location = new System.Drawing.Point(85, 29);
            this.txttencl.Name = "txttencl";
            this.txttencl.Size = new System.Drawing.Size(106, 20);
            this.txttencl.TabIndex = 0;
            // 
            // lblcuoicl
            // 
            this.lblcuoicl.AutoSize = true;
            this.lblcuoicl.Location = new System.Drawing.Point(196, 67);
            this.lblcuoicl.Name = "lblcuoicl";
            this.lblcuoicl.Size = new System.Drawing.Size(62, 13);
            this.lblcuoicl.TabIndex = 2;
            this.lblcuoicl.Text = "Kết thúc ca";
            // 
            // lbldaucl
            // 
            this.lbldaucl.AutoSize = true;
            this.lbldaucl.Location = new System.Drawing.Point(14, 67);
            this.lbldaucl.Name = "lbldaucl";
            this.lbldaucl.Size = new System.Drawing.Size(60, 13);
            this.lbldaucl.TabIndex = 1;
            this.lbldaucl.Text = "Bắt đầu ca";
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
            this.ClientSize = new System.Drawing.Size(387, 347);
            this.Controls.Add(this.gbthongtincl);
            this.Controls.Add(this.gbchucnangcl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fcl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ca làm việc";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sttcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencl;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiancl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcl;
        private System.Windows.Forms.Label lblcuoicl;
        private System.Windows.Forms.Label lbldaucl;
        private System.Windows.Forms.Label lbltencl;
        private System.Windows.Forms.DateTimePicker dtpcuoicl;
        private System.Windows.Forms.DateTimePicker dtpdaucl;
        private System.Windows.Forms.TextBox txttencl;
    }
}