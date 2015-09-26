namespace QLBanHang
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
            this.gbdshdban = new System.Windows.Forms.GroupBox();
            this.dtgdshdban = new System.Windows.Forms.DataGridView();
            this.gbchucnanghdban = new System.Windows.Forms.GroupBox();
            this.btnchitiethdban = new System.Windows.Forms.Button();
            this.btntimhdban = new System.Windows.Forms.Button();
            this.btnprinthdban = new System.Windows.Forms.Button();
            this.gbthongtinhdban = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtngaycuoihdban = new System.Windows.Forms.DateTimePicker();
            this.numtongtienhdban = new System.Windows.Forms.NumericUpDown();
            this.cbbtrangthaihdban = new System.Windows.Forms.ComboBox();
            this.lbltrangthaihdban = new System.Windows.Forms.Label();
            this.lbldvgiahdnhap = new System.Windows.Forms.Label();
            this.cbbnvtaohd = new System.Windows.Forms.ComboBox();
            this.cbbkhhdban = new System.Windows.Forms.ComboBox();
            this.cbbhdban = new System.Windows.Forms.ComboBox();
            this.dtngaydauhdban = new System.Windows.Forms.DateTimePicker();
            this.lbltongtienhdban = new System.Windows.Forms.Label();
            this.lblhdban = new System.Windows.Forms.Label();
            this.lblnvtaohd = new System.Windows.Forms.Label();
            this.lblkhhdban = new System.Windows.Forms.Label();
            this.lblngayhdban = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhdnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybanhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhhdban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phivanchuyenhdban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuevathdban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienhdnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaihdnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbdshdban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdshdban)).BeginInit();
            this.gbchucnanghdban.SuspendLayout();
            this.gbthongtinhdban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtongtienhdban)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdshdban
            // 
            this.gbdshdban.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbdshdban.Controls.Add(this.dtgdshdban);
            this.gbdshdban.Location = new System.Drawing.Point(12, 156);
            this.gbdshdban.Name = "gbdshdban";
            this.gbdshdban.Size = new System.Drawing.Size(726, 312);
            this.gbdshdban.TabIndex = 2;
            this.gbdshdban.TabStop = false;
            this.gbdshdban.Text = "Danh sách hóa đơn bán";
            // 
            // dtgdshdban
            // 
            this.dtgdshdban.AllowUserToAddRows = false;
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
            // gbthongtinhdban
            // 
            this.gbthongtinhdban.Controls.Add(this.label1);
            this.gbthongtinhdban.Controls.Add(this.dtngaycuoihdban);
            this.gbthongtinhdban.Controls.Add(this.numtongtienhdban);
            this.gbthongtinhdban.Controls.Add(this.cbbtrangthaihdban);
            this.gbthongtinhdban.Controls.Add(this.lbltrangthaihdban);
            this.gbthongtinhdban.Controls.Add(this.lbldvgiahdnhap);
            this.gbthongtinhdban.Controls.Add(this.cbbnvtaohd);
            this.gbthongtinhdban.Controls.Add(this.cbbkhhdban);
            this.gbthongtinhdban.Controls.Add(this.cbbhdban);
            this.gbthongtinhdban.Controls.Add(this.dtngaydauhdban);
            this.gbthongtinhdban.Controls.Add(this.lbltongtienhdban);
            this.gbthongtinhdban.Controls.Add(this.lblhdban);
            this.gbthongtinhdban.Controls.Add(this.lblnvtaohd);
            this.gbthongtinhdban.Controls.Add(this.lblkhhdban);
            this.gbthongtinhdban.Controls.Add(this.lblngayhdban);
            this.gbthongtinhdban.Location = new System.Drawing.Point(12, 12);
            this.gbthongtinhdban.Name = "gbthongtinhdban";
            this.gbthongtinhdban.Size = new System.Drawing.Size(606, 138);
            this.gbthongtinhdban.TabIndex = 0;
            this.gbthongtinhdban.TabStop = false;
            this.gbthongtinhdban.Text = "Thông tin";
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
            // dtngaycuoihdban
            // 
            this.dtngaycuoihdban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaycuoihdban.Location = new System.Drawing.Point(220, 63);
            this.dtngaycuoihdban.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtngaycuoihdban.MinDate = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            this.dtngaycuoihdban.Name = "dtngaycuoihdban";
            this.dtngaycuoihdban.Size = new System.Drawing.Size(83, 20);
            this.dtngaycuoihdban.TabIndex = 2;
            this.dtngaycuoihdban.Value = new System.DateTime(2015, 9, 15, 0, 0, 0, 0);
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
            // lbltrangthaihdban
            // 
            this.lbltrangthaihdban.AutoSize = true;
            this.lbltrangthaihdban.Location = new System.Drawing.Point(325, 103);
            this.lbltrangthaihdban.Name = "lbltrangthaihdban";
            this.lbltrangthaihdban.Size = new System.Drawing.Size(55, 13);
            this.lbltrangthaihdban.TabIndex = 17;
            this.lbltrangthaihdban.Text = "Trạng thái";
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
            // cbbnvtaohd
            // 
            this.cbbnvtaohd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbbnvtaohd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbnvtaohd.FormattingEnabled = true;
            this.cbbnvtaohd.Location = new System.Drawing.Point(414, 26);
            this.cbbnvtaohd.Name = "cbbnvtaohd";
            this.cbbnvtaohd.Size = new System.Drawing.Size(171, 21);
            this.cbbnvtaohd.TabIndex = 4;
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
            // dtngaydauhdban
            // 
            this.dtngaydauhdban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaydauhdban.Location = new System.Drawing.Point(99, 63);
            this.dtngaydauhdban.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtngaydauhdban.MinDate = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            this.dtngaydauhdban.Name = "dtngaydauhdban";
            this.dtngaydauhdban.Size = new System.Drawing.Size(90, 20);
            this.dtngaydauhdban.TabIndex = 1;
            this.dtngaydauhdban.Value = new System.DateTime(2015, 9, 15, 0, 0, 0, 0);
            // 
            // lbltongtienhdban
            // 
            this.lbltongtienhdban.AutoSize = true;
            this.lbltongtienhdban.Location = new System.Drawing.Point(18, 104);
            this.lbltongtienhdban.Name = "lbltongtienhdban";
            this.lbltongtienhdban.Size = new System.Drawing.Size(52, 13);
            this.lbltongtienhdban.TabIndex = 4;
            this.lbltongtienhdban.Text = "Tổng tiền";
            // 
            // lblhdban
            // 
            this.lblhdban.AutoSize = true;
            this.lblhdban.Location = new System.Drawing.Point(17, 30);
            this.lblhdban.Name = "lblhdban";
            this.lblhdban.Size = new System.Drawing.Size(70, 13);
            this.lblhdban.TabIndex = 3;
            this.lblhdban.Text = "Hóa đơn bán";
            // 
            // lblnvtaohd
            // 
            this.lblnvtaohd.AutoSize = true;
            this.lblnvtaohd.Location = new System.Drawing.Point(325, 29);
            this.lblnvtaohd.Name = "lblnvtaohd";
            this.lblnvtaohd.Size = new System.Drawing.Size(74, 13);
            this.lblnvtaohd.TabIndex = 2;
            this.lblnvtaohd.Text = "Nhân viên tạo";
            // 
            // lblkhhdban
            // 
            this.lblkhhdban.AutoSize = true;
            this.lblkhhdban.Location = new System.Drawing.Point(325, 66);
            this.lblkhhdban.Name = "lblkhhdban";
            this.lblkhhdban.Size = new System.Drawing.Size(65, 13);
            this.lblkhhdban.TabIndex = 1;
            this.lblkhhdban.Text = "Khách hàng";
            // 
            // lblngayhdban
            // 
            this.lblngayhdban.AutoSize = true;
            this.lblngayhdban.Location = new System.Drawing.Point(18, 67);
            this.lblngayhdban.Name = "lblngayhdban";
            this.lblngayhdban.Size = new System.Drawing.Size(53, 13);
            this.lblngayhdban.TabIndex = 0;
            this.lblngayhdban.Text = "Ngày bán";
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
            this.tenhdnhap.DataPropertyName = "idhdban";
            this.tenhdnhap.HeaderText = "Tên hóa đơn";
            this.tenhdnhap.Name = "tenhdnhap";
            this.tenhdnhap.ReadOnly = true;
            this.tenhdnhap.Width = 93;
            // 
            // ngaybanhd
            // 
            this.ngaybanhd.DataPropertyName = "ngayghihdban";
            this.ngaybanhd.HeaderText = "Ngày bán";
            this.ngaybanhd.Name = "ngaybanhd";
            this.ngaybanhd.ReadOnly = true;
            this.ngaybanhd.Width = 77;
            // 
            // tenkhhdban
            // 
            this.tenkhhdban.DataPropertyName = "hotenkh";
            this.tenkhhdban.HeaderText = "Khách hàng";
            this.tenkhhdban.Name = "tenkhhdban";
            this.tenkhhdban.ReadOnly = true;
            this.tenkhhdban.Width = 89;
            // 
            // phivanchuyenhdban
            // 
            this.phivanchuyenhdban.DataPropertyName = "phivanchuyen";
            this.phivanchuyenhdban.HeaderText = "Phí vận chuyển";
            this.phivanchuyenhdban.Name = "phivanchuyenhdban";
            this.phivanchuyenhdban.ReadOnly = true;
            this.phivanchuyenhdban.Width = 107;
            // 
            // thuevathdban
            // 
            this.thuevathdban.DataPropertyName = "thueVAT";
            this.thuevathdban.HeaderText = "Thuế VAT";
            this.thuevathdban.Name = "thuevathdban";
            this.thuevathdban.ReadOnly = true;
            this.thuevathdban.Width = 80;
            // 
            // tongtienhdnhap
            // 
            this.tongtienhdnhap.DataPropertyName = "tongtienhdban";
            this.tongtienhdnhap.HeaderText = "Tổng tiền";
            this.tongtienhdnhap.Name = "tongtienhdnhap";
            this.tongtienhdnhap.ReadOnly = true;
            this.tongtienhdnhap.Width = 76;
            // 
            // trangthaihdnhap
            // 
            this.trangthaihdnhap.DataPropertyName = "trangthai";
            this.trangthaihdnhap.HeaderText = "Trạng thái";
            this.trangthaihdnhap.Name = "trangthaihdnhap";
            this.trangthaihdnhap.ReadOnly = true;
            this.trangthaihdnhap.Width = 79;
            // 
            // nvnhap
            // 
            this.nvnhap.DataPropertyName = "tennv";
            this.nvnhap.HeaderText = "Nhân viên nhập hóa đơn";
            this.nvnhap.Name = "nvnhap";
            this.nvnhap.ReadOnly = true;
            this.nvnhap.Width = 150;
            // 
            // fhdban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.gbdshdban);
            this.Controls.Add(this.gbchucnanghdban);
            this.Controls.Add(this.gbthongtinhdban);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fhdban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán";
            this.Load += new System.EventHandler(this.fhdban_Load);
            this.gbdshdban.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdshdban)).EndInit();
            this.gbchucnanghdban.ResumeLayout(false);
            this.gbthongtinhdban.ResumeLayout(false);
            this.gbthongtinhdban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtongtienhdban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdshdban;
        private System.Windows.Forms.DataGridView dtgdshdban;
        private System.Windows.Forms.GroupBox gbchucnanghdban;
        private System.Windows.Forms.Button btnchitiethdban;
        private System.Windows.Forms.Button btntimhdban;
        private System.Windows.Forms.Button btnprinthdban;
        private System.Windows.Forms.GroupBox gbthongtinhdban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtngaycuoihdban;
        private System.Windows.Forms.NumericUpDown numtongtienhdban;
        private System.Windows.Forms.ComboBox cbbtrangthaihdban;
        private System.Windows.Forms.Label lbltrangthaihdban;
        private System.Windows.Forms.Label lbldvgiahdnhap;
        private System.Windows.Forms.ComboBox cbbnvtaohd;
        private System.Windows.Forms.ComboBox cbbkhhdban;
        private System.Windows.Forms.ComboBox cbbhdban;
        private System.Windows.Forms.DateTimePicker dtngaydauhdban;
        private System.Windows.Forms.Label lbltongtienhdban;
        private System.Windows.Forms.Label lblhdban;
        private System.Windows.Forms.Label lblnvtaohd;
        private System.Windows.Forms.Label lblkhhdban;
        private System.Windows.Forms.Label lblngayhdban;
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