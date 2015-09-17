namespace OrderSoftManager
{
    partial class fphanquyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fphanquyen));
            this.gbquyennv = new System.Windows.Forms.GroupBox();
            this.btnquyennv = new System.Windows.Forms.Button();
            this.chbquyennv = new System.Windows.Forms.CheckedListBox();
            this.gbdsquyennv = new System.Windows.Forms.GroupBox();
            this.dtgdsquyennv = new System.Windows.Forms.DataGridView();
            this.sttphanquyennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennvphanquyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyenhannv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbquyennv = new System.Windows.Forms.ComboBox();
            this.lblquyennv = new System.Windows.Forms.Label();
            this.gbquyennv.SuspendLayout();
            this.gbdsquyennv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsquyennv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbquyennv
            // 
            this.gbquyennv.Controls.Add(this.btnquyennv);
            this.gbquyennv.Controls.Add(this.chbquyennv);
            this.gbquyennv.Location = new System.Drawing.Point(12, 12);
            this.gbquyennv.Name = "gbquyennv";
            this.gbquyennv.Size = new System.Drawing.Size(133, 161);
            this.gbquyennv.TabIndex = 1;
            this.gbquyennv.TabStop = false;
            this.gbquyennv.Text = "Quyền hạn";
            // 
            // btnquyennv
            // 
            this.btnquyennv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquyennv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnquyennv.Location = new System.Drawing.Point(29, 119);
            this.btnquyennv.Name = "btnquyennv";
            this.btnquyennv.Size = new System.Drawing.Size(75, 24);
            this.btnquyennv.TabIndex = 1;
            this.btnquyennv.Text = "Cấp quyền";
            this.btnquyennv.UseVisualStyleBackColor = true;
            // 
            // chbquyennv
            // 
            this.chbquyennv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chbquyennv.CheckOnClick = true;
            this.chbquyennv.FormattingEnabled = true;
            this.chbquyennv.Items.AddRange(new object[] {
            "Admin",
            "Quản lý",
            "Kinh doanh",
            "Kế toán",
            "Kho"});
            this.chbquyennv.Location = new System.Drawing.Point(17, 27);
            this.chbquyennv.Name = "chbquyennv";
            this.chbquyennv.Size = new System.Drawing.Size(105, 75);
            this.chbquyennv.TabIndex = 0;
            // 
            // gbdsquyennv
            // 
            this.gbdsquyennv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbdsquyennv.Controls.Add(this.dtgdsquyennv);
            this.gbdsquyennv.Controls.Add(this.cbbquyennv);
            this.gbdsquyennv.Controls.Add(this.lblquyennv);
            this.gbdsquyennv.Location = new System.Drawing.Point(151, 12);
            this.gbdsquyennv.Name = "gbdsquyennv";
            this.gbdsquyennv.Size = new System.Drawing.Size(287, 161);
            this.gbdsquyennv.TabIndex = 0;
            this.gbdsquyennv.TabStop = false;
            this.gbdsquyennv.Text = "Danh sách nhân viên";
            // 
            // dtgdsquyennv
            // 
            this.dtgdsquyennv.AllowUserToResizeRows = false;
            this.dtgdsquyennv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdsquyennv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgdsquyennv.BackgroundColor = System.Drawing.Color.White;
            this.dtgdsquyennv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdsquyennv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgdsquyennv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgdsquyennv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgdsquyennv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttphanquyennv,
            this.tennvphanquyen,
            this.quyenhannv});
            this.dtgdsquyennv.EnableHeadersVisualStyles = false;
            this.dtgdsquyennv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgdsquyennv.Location = new System.Drawing.Point(6, 55);
            this.dtgdsquyennv.Name = "dtgdsquyennv";
            this.dtgdsquyennv.ReadOnly = true;
            this.dtgdsquyennv.RowHeadersVisible = false;
            this.dtgdsquyennv.Size = new System.Drawing.Size(275, 100);
            this.dtgdsquyennv.TabIndex = 1;
            // 
            // sttphanquyennv
            // 
            this.sttphanquyennv.HeaderText = "STT";
            this.sttphanquyennv.Name = "sttphanquyennv";
            this.sttphanquyennv.ReadOnly = true;
            this.sttphanquyennv.Width = 52;
            // 
            // tennvphanquyen
            // 
            this.tennvphanquyen.HeaderText = "Nhân viên";
            this.tennvphanquyen.Name = "tennvphanquyen";
            this.tennvphanquyen.ReadOnly = true;
            this.tennvphanquyen.Width = 80;
            // 
            // quyenhannv
            // 
            this.quyenhannv.HeaderText = "Quyền hạn";
            this.quyenhannv.Name = "quyenhannv";
            this.quyenhannv.ReadOnly = true;
            this.quyenhannv.Width = 83;
            // 
            // cbbquyennv
            // 
            this.cbbquyennv.BackColor = System.Drawing.Color.White;
            this.cbbquyennv.FormattingEnabled = true;
            this.cbbquyennv.Location = new System.Drawing.Point(79, 21);
            this.cbbquyennv.Name = "cbbquyennv";
            this.cbbquyennv.Size = new System.Drawing.Size(195, 21);
            this.cbbquyennv.TabIndex = 0;
            // 
            // lblquyennv
            // 
            this.lblquyennv.AutoSize = true;
            this.lblquyennv.Location = new System.Drawing.Point(17, 24);
            this.lblquyennv.Name = "lblquyennv";
            this.lblquyennv.Size = new System.Drawing.Size(56, 13);
            this.lblquyennv.TabIndex = 3;
            this.lblquyennv.Text = "Nhân viên";
            // 
            // fphanquyen
            // 
            this.AcceptButton = this.btnquyennv;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 185);
            this.Controls.Add(this.gbdsquyennv);
            this.Controls.Add(this.gbquyennv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fphanquyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền hệ thống";
            this.gbquyennv.ResumeLayout(false);
            this.gbdsquyennv.ResumeLayout(false);
            this.gbdsquyennv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsquyennv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbquyennv;
        private System.Windows.Forms.GroupBox gbdsquyennv;
        private System.Windows.Forms.Button btnquyennv;
        private System.Windows.Forms.CheckedListBox chbquyennv;
        private System.Windows.Forms.ComboBox cbbquyennv;
        private System.Windows.Forms.Label lblquyennv;
        private System.Windows.Forms.DataGridView dtgdsquyennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttphanquyennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennvphanquyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyenhannv;
    }
}