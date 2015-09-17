namespace OrderSoftManager
{
    partial class fhdban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fhdban));
            this.gbdshdnhap = new System.Windows.Forms.GroupBox();
            this.dtgdshdban = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhdnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybanhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhhdban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phivanchuyenhdban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuevathdban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienhdnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaihdnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbchucnanghdban = new System.Windows.Forms.GroupBox();
            this.btnchitiethdban = new System.Windows.Forms.Button();
            this.btntimhdban = new System.Windows.Forms.Button();
            this.btnprinthdban = new System.Windows.Forms.Button();
            this.gbtimhdban = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpngaysauhdban = new System.Windows.Forms.DateTimePicker();
            this.numtongtienhdban = new System.Windows.Forms.NumericUpDown();
            this.cbbtrangthaihdban = new System.Windows.Forms.ComboBox();
            this.lbltrangthaihdnhap = new System.Windows.Forms.Label();
            this.lbldvgiahdnhap = new System.Windows.Forms.Label();
            this.cbbnvnhaphd = new System.Windows.Forms.ComboBox();
            this.cbbkhhdban = new System.Windows.Forms.ComboBox();
            this.cbbhdban = new System.Windows.Forms.ComboBox();
            this.dtpngaydauhdban = new System.Windows.Forms.DateTimePicker();
            this.lbltongtienhdnhap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnvnhaphd = new System.Windows.Forms.Label();
            this.lblncchdnhap = new System.Windows.Forms.Label();
            this.lblngaynhaphd = new System.Windows.Forms.Label();
            this.gbdshdnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdshdban)).BeginInit();
            this.gbchucnanghdban.SuspendLayout();
            this.gbtimhdban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtongtienhdban)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdshdnhap
            // 
            this.gbdshdnhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbdshdnhap.Controls.Add(this.dtgdshdban);
            this.gbdshdnhap.Location = new System.Drawing.Point(12, 156);
            this.gbdshdnhap.Name = "gbdshdnhap";
            this.gbdshdnhap.Size = new System.Drawing.Size(726, 312);
            this.gbdshdnhap.TabIndex = 2;
            this.gbdshdnhap.TabStop = false;
            this.gbdshdnhap.Text = "Danh sách hóa đơn nhập";
            // 
            // dtgdshdban
            // 
            this.dtgdshdban.AllowUserToResizeRows = false;
            this.dtgdshdban.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdshdban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgdshdban.BackgroundColor = System.Drawing.Color.White;
            this.dtgdshdban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdshdban.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgdshdban.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgdshdban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgdshdban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tenhdnhap,
            this.ngaybanhd,
            this.tenkhhdban,
            this.phivanchuyenhdban,
            this.thuevathdban,
            this.tongtienhdnhap,
            this.trangthaihdnhap,
            this.nvnhap});
            this.dtgdshdban.EnableHeadersVisualStyles = false;
            this.dtgdshdban.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgdshdban.Location = new System.Drawing.Point(6, 19);
            this.dtgdshdban.Name = "dtgdshdban";
            this.dtgdshdban.ReadOnly = true;
            this.dtgdshdban.RowHeadersVisible = false;
            this.dtgdshdban.Size = new System.Drawing.Size(714, 287);
            this.dtgdshdban.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 52;
            // 
            // tenhdnhap
            // 
            this.tenhdnhap.HeaderText = "Tên hóa đơn";
            this.tenhdnhap.Name = "tenhdnhap";
            this.tenhdnhap.ReadOnly = true;
            this.tenhdnhap.Width = 93;
            // 
            // ngaybanhd
            // 
            this.ngaybanhd.HeaderText = "Ngày bán";
            this.ngaybanhd.Name = "ngaybanhd";
            this.ngaybanhd.ReadOnly = true;
            this.ngaybanhd.Width = 77;
            // 
            // tenkhhdban
            // 
            this.tenkhhdban.HeaderText = "Khách hàng";
            this.tenkhhdban.Name = "tenkhhdban";
            this.tenkhhdban.ReadOnly = true;
            this.tenkhhdban.Width = 89;
            // 
            // phivanchuyenhdban
            // 
            this.phivanchuyenhdban.HeaderText = "Phí vận chuyển";
            this.phivanchuyenhdban.Name = "phivanchuyenhdban";
            this.phivanchuyenhdban.ReadOnly = true;
            this.phivanchuyenhdban.Width = 107;
            // 
            // thuevathdban
            // 
            this.thuevathdban.HeaderText = "Thuế VAT";
            this.thuevathdban.Name = "thuevathdban";
            this.thuevathdban.ReadOnly = true;
            this.thuevathdban.Width = 80;
            // 
            // tongtienhdnhap
            // 
            this.tongtienhdnhap.HeaderText = "Tổng tiền";
            this.tongtienhdnhap.Name = "tongtienhdnhap";
            this.tongtienhdnhap.ReadOnly = true;
            this.tongtienhdnhap.Width = 76;
            // 
            // trangthaihdnhap
            // 
            this.trangthaihdnhap.HeaderText = "Trạng thái";
            this.trangthaihdnhap.Name = "trangthaihdnhap";
            this.trangthaihdnhap.ReadOnly = true;
            this.trangthaihdnhap.Width = 79;
            // 
            // nvnhap
            // 
            this.nvnhap.HeaderText = "Nhân viên nhập hóa đơn";
            this.nvnhap.Name = "nvnhap";
            this.nvnhap.ReadOnly = true;
            this.nvnhap.Width = 150;
            // 
            // gbchucnanghdban
            // 
            this.gbchucnanghdban.Controls.Add(this.btnchitiethdban);
            this.gbchucnanghdban.Controls.Add(this.btntimhdban);
            this.gbchucnanghdban.Controls.Add(this.btnprinthdban);
            this.gbchucnanghdban.Location = new System.Drawing.Point(624, 12);
            this.gbchucnanghdban.Name = "gbchucnanghdban";
            this.gbchucnanghdban.Size = new System.Drawing.Size(113, 138);
            this.gbchucnanghdban.TabIndex = 1;
            this.gbchucnanghdban.TabStop = false;
            this.gbchucnanghdban.Text = "Chức năng";
            // 
            // btnchitiethdban
            // 
            this.btnchitiethdban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchitiethdban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnchitiethdban.Location = new System.Drawing.Point(18, 100);
            this.btnchitiethdban.Name = "btnchitiethdban";
            this.btnchitiethdban.Size = new System.Drawing.Size(75, 23);
            this.btnchitiethdban.TabIndex = 2;
            this.btnchitiethdban.Text = "Sửa";
            this.btnchitiethdban.UseVisualStyleBackColor = true;
            // 
            // btntimhdban
            // 
            this.btntimhdban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntimhdban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntimhdban.Location = new System.Drawing.Point(18, 28);
            this.btntimhdban.Name = "btntimhdban";
            this.btntimhdban.Size = new System.Drawing.Size(75, 23);
            this.btntimhdban.TabIndex = 1;
            this.btntimhdban.Text = "Tìm";
            this.btntimhdban.UseVisualStyleBackColor = true;
            // 
            // btnprinthdban
            // 
            this.btnprinthdban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprinthdban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnprinthdban.Location = new System.Drawing.Point(18, 64);
            this.btnprinthdban.Name = "btnprinthdban";
            this.btnprinthdban.Size = new System.Drawing.Size(75, 23);
            this.btnprinthdban.TabIndex = 3;
            this.btnprinthdban.Text = "In";
            this.btnprinthdban.UseVisualStyleBackColor = true;
            // 
            // gbtimhdban
            // 
            this.gbtimhdban.Controls.Add(this.label1);
            this.gbtimhdban.Controls.Add(this.dtpngaysauhdban);
            this.gbtimhdban.Controls.Add(this.numtongtienhdban);
            this.gbtimhdban.Controls.Add(this.cbbtrangthaihdban);
            this.gbtimhdban.Controls.Add(this.lbltrangthaihdnhap);
            this.gbtimhdban.Controls.Add(this.lbldvgiahdnhap);
            this.gbtimhdban.Controls.Add(this.cbbnvnhaphd);
            this.gbtimhdban.Controls.Add(this.cbbkhhdban);
            this.gbtimhdban.Controls.Add(this.cbbhdban);
            this.gbtimhdban.Controls.Add(this.dtpngaydauhdban);
            this.gbtimhdban.Controls.Add(this.lbltongtienhdnhap);
            this.gbtimhdban.Controls.Add(this.label4);
            this.gbtimhdban.Controls.Add(this.lblnvnhaphd);
            this.gbtimhdban.Controls.Add(this.lblncchdnhap);
            this.gbtimhdban.Controls.Add(this.lblngaynhaphd);
            this.gbtimhdban.Location = new System.Drawing.Point(12, 12);
            this.gbtimhdban.Name = "gbtimhdban";
            this.gbtimhdban.Size = new System.Drawing.Size(606, 138);
            this.gbtimhdban.TabIndex = 0;
            this.gbtimhdban.TabStop = false;
            this.gbtimhdban.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(195, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpngaysauhdban
            // 
            this.dtpngaysauhdban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysauhdban.Location = new System.Drawing.Point(220, 63);
            this.dtpngaysauhdban.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpngaysauhdban.MinDate = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            this.dtpngaysauhdban.Name = "dtpngaysauhdban";
            this.dtpngaysauhdban.Size = new System.Drawing.Size(83, 20);
            this.dtpngaysauhdban.TabIndex = 2;
            this.dtpngaysauhdban.Value = new System.DateTime(2015, 9, 15, 0, 0, 0, 0);
            // 
            // numtongtienhdban
            // 
            this.numtongtienhdban.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numtongtienhdban.Location = new System.Drawing.Point(100, 100);
            this.numtongtienhdban.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numtongtienhdban.Name = "numtongtienhdban";
            this.numtongtienhdban.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numtongtienhdban.Size = new System.Drawing.Size(145, 20);
            this.numtongtienhdban.TabIndex = 3;
            // 
            // cbbtrangthaihdban
            // 
            this.cbbtrangthaihdban.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbbtrangthaihdban.FormattingEnabled = true;
            this.cbbtrangthaihdban.Location = new System.Drawing.Point(414, 100);
            this.cbbtrangthaihdban.Name = "cbbtrangthaihdban";
            this.cbbtrangthaihdban.Size = new System.Drawing.Size(171, 21);
            this.cbbtrangthaihdban.TabIndex = 6;
            // 
            // lbltrangthaihdnhap
            // 
            this.lbltrangthaihdnhap.AutoSize = true;
            this.lbltrangthaihdnhap.Location = new System.Drawing.Point(325, 103);
            this.lbltrangthaihdnhap.Name = "lbltrangthaihdnhap";
            this.lbltrangthaihdnhap.Size = new System.Drawing.Size(55, 13);
            this.lbltrangthaihdnhap.TabIndex = 17;
            this.lbltrangthaihdnhap.Text = "Trạng thái";
            // 
            // lbldvgiahdnhap
            // 
            this.lbldvgiahdnhap.BackColor = System.Drawing.Color.White;
            this.lbldvgiahdnhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldvgiahdnhap.Location = new System.Drawing.Point(251, 99);
            this.lbldvgiahdnhap.Name = "lbldvgiahdnhap";
            this.lbldvgiahdnhap.Size = new System.Drawing.Size(32, 23);
            this.lbldvgiahdnhap.TabIndex = 16;
            this.lbldvgiahdnhap.Text = "VNĐ";
            this.lbldvgiahdnhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbnvnhaphd
            // 
            this.cbbnvnhaphd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbbnvnhaphd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbnvnhaphd.FormattingEnabled = true;
            this.cbbnvnhaphd.Location = new System.Drawing.Point(414, 26);
            this.cbbnvnhaphd.Name = "cbbnvnhaphd";
            this.cbbnvnhaphd.Size = new System.Drawing.Size(171, 21);
            this.cbbnvnhaphd.TabIndex = 4;
            // 
            // cbbkhhdban
            // 
            this.cbbkhhdban.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbbkhhdban.FormattingEnabled = true;
            this.cbbkhhdban.Location = new System.Drawing.Point(414, 63);
            this.cbbkhhdban.Name = "cbbkhhdban";
            this.cbbkhhdban.Size = new System.Drawing.Size(171, 21);
            this.cbbkhhdban.TabIndex = 5;
            // 
            // cbbhdban
            // 
            this.cbbhdban.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbbhdban.FormattingEnabled = true;
            this.cbbhdban.Location = new System.Drawing.Point(99, 26);
            this.cbbhdban.Name = "cbbhdban";
            this.cbbhdban.Size = new System.Drawing.Size(204, 21);
            this.cbbhdban.TabIndex = 0;
            // 
            // dtpngaydauhdban
            // 
            this.dtpngaydauhdban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaydauhdban.Location = new System.Drawing.Point(99, 63);
            this.dtpngaydauhdban.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpngaydauhdban.MinDate = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            this.dtpngaydauhdban.Name = "dtpngaydauhdban";
            this.dtpngaydauhdban.Size = new System.Drawing.Size(90, 20);
            this.dtpngaydauhdban.TabIndex = 1;
            this.dtpngaydauhdban.Value = new System.DateTime(2015, 9, 15, 0, 0, 0, 0);
            // 
            // lbltongtienhdnhap
            // 
            this.lbltongtienhdnhap.AutoSize = true;
            this.lbltongtienhdnhap.Location = new System.Drawing.Point(18, 104);
            this.lbltongtienhdnhap.Name = "lbltongtienhdnhap";
            this.lbltongtienhdnhap.Size = new System.Drawing.Size(52, 13);
            this.lbltongtienhdnhap.TabIndex = 4;
            this.lbltongtienhdnhap.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hóa đơn bán";
            // 
            // lblnvnhaphd
            // 
            this.lblnvnhaphd.AutoSize = true;
            this.lblnvnhaphd.Location = new System.Drawing.Point(325, 29);
            this.lblnvnhaphd.Name = "lblnvnhaphd";
            this.lblnvnhaphd.Size = new System.Drawing.Size(83, 13);
            this.lblnvnhaphd.TabIndex = 2;
            this.lblnvnhaphd.Text = "Nhân viên nhập";
            // 
            // lblncchdnhap
            // 
            this.lblncchdnhap.AutoSize = true;
            this.lblncchdnhap.Location = new System.Drawing.Point(325, 66);
            this.lblncchdnhap.Name = "lblncchdnhap";
            this.lblncchdnhap.Size = new System.Drawing.Size(65, 13);
            this.lblncchdnhap.TabIndex = 1;
            this.lblncchdnhap.Text = "Khách hàng";
            // 
            // lblngaynhaphd
            // 
            this.lblngaynhaphd.AutoSize = true;
            this.lblngaynhaphd.Location = new System.Drawing.Point(18, 67);
            this.lblngaynhaphd.Name = "lblngaynhaphd";
            this.lblngaynhaphd.Size = new System.Drawing.Size(53, 13);
            this.lblngaynhaphd.TabIndex = 0;
            this.lblngaynhaphd.Text = "Ngày bán";
            // 
            // fhdban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.gbdshdnhap);
            this.Controls.Add(this.gbchucnanghdban);
            this.Controls.Add(this.gbtimhdban);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fhdban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán";
            this.gbdshdnhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdshdban)).EndInit();
            this.gbchucnanghdban.ResumeLayout(false);
            this.gbtimhdban.ResumeLayout(false);
            this.gbtimhdban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtongtienhdban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdshdnhap;
        private System.Windows.Forms.DataGridView dtgdshdban;
        private System.Windows.Forms.GroupBox gbchucnanghdban;
        private System.Windows.Forms.Button btnchitiethdban;
        private System.Windows.Forms.Button btntimhdban;
        private System.Windows.Forms.Button btnprinthdban;
        private System.Windows.Forms.GroupBox gbtimhdban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpngaysauhdban;
        private System.Windows.Forms.NumericUpDown numtongtienhdban;
        private System.Windows.Forms.ComboBox cbbtrangthaihdban;
        private System.Windows.Forms.Label lbltrangthaihdnhap;
        private System.Windows.Forms.Label lbldvgiahdnhap;
        private System.Windows.Forms.ComboBox cbbnvnhaphd;
        private System.Windows.Forms.ComboBox cbbkhhdban;
        private System.Windows.Forms.ComboBox cbbhdban;
        private System.Windows.Forms.DateTimePicker dtpngaydauhdban;
        private System.Windows.Forms.Label lbltongtienhdnhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnvnhaphd;
        private System.Windows.Forms.Label lblncchdnhap;
        private System.Windows.Forms.Label lblngaynhaphd;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhdnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybanhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhhdban;
        private System.Windows.Forms.DataGridViewTextBoxColumn phivanchuyenhdban;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuevathdban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienhdnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaihdnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvnhap;
    }
}