namespace OrderSoftManager
{
    partial class floaikh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(floaikh));
            this.gbthongtinloaikh = new System.Windows.Forms.GroupBox();
            this.dtgdsloaikh = new System.Windows.Forms.DataGridView();
            this.sttcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idloaikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttenloaikh = new System.Windows.Forms.TextBox();
            this.lbltenloaikh = new System.Windows.Forms.Label();
            this.gbchucnangloaikh = new System.Windows.Forms.GroupBox();
            this.btnchitietloaikh = new System.Windows.Forms.Button();
            this.btndelloaikh = new System.Windows.Forms.Button();
            this.btneditloaikh = new System.Windows.Forms.Button();
            this.btnaddloaikh = new System.Windows.Forms.Button();
            this.gbthongtinloaikh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsloaikh)).BeginInit();
            this.gbchucnangloaikh.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbthongtinloaikh
            // 
            this.gbthongtinloaikh.Controls.Add(this.dtgdsloaikh);
            this.gbthongtinloaikh.Controls.Add(this.txttenloaikh);
            this.gbthongtinloaikh.Controls.Add(this.lbltenloaikh);
            this.gbthongtinloaikh.Location = new System.Drawing.Point(12, 83);
            this.gbthongtinloaikh.Name = "gbthongtinloaikh";
            this.gbthongtinloaikh.Size = new System.Drawing.Size(375, 264);
            this.gbthongtinloaikh.TabIndex = 0;
            this.gbthongtinloaikh.TabStop = false;
            this.gbthongtinloaikh.Text = "Thông tin loại khách hàng";
            // 
            // dtgdsloaikh
            // 
            this.dtgdsloaikh.AllowUserToResizeRows = false;
            this.dtgdsloaikh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdsloaikh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgdsloaikh.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgdsloaikh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdsloaikh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgdsloaikh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgdsloaikh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgdsloaikh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttcl,
            this.tenloaikh,
            this.idloaikh});
            this.dtgdsloaikh.EnableHeadersVisualStyles = false;
            this.dtgdsloaikh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgdsloaikh.Location = new System.Drawing.Point(6, 61);
            this.dtgdsloaikh.Name = "dtgdsloaikh";
            this.dtgdsloaikh.ReadOnly = true;
            this.dtgdsloaikh.RowHeadersVisible = false;
            this.dtgdsloaikh.Size = new System.Drawing.Size(363, 197);
            this.dtgdsloaikh.TabIndex = 3;
            // 
            // sttcl
            // 
            this.sttcl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sttcl.HeaderText = "STT";
            this.sttcl.Name = "sttcl";
            this.sttcl.ReadOnly = true;
            this.sttcl.Width = 52;
            // 
            // tenloaikh
            // 
            this.tenloaikh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenloaikh.HeaderText = "Tên loại khách hàng";
            this.tenloaikh.Name = "tenloaikh";
            this.tenloaikh.ReadOnly = true;
            this.tenloaikh.Width = 129;
            // 
            // idloaikh
            // 
            this.idloaikh.HeaderText = "idloaikh";
            this.idloaikh.Name = "idloaikh";
            this.idloaikh.ReadOnly = true;
            this.idloaikh.Visible = false;
            this.idloaikh.Width = 68;
            // 
            // txttenloaikh
            // 
            this.txttenloaikh.Location = new System.Drawing.Point(77, 26);
            this.txttenloaikh.Name = "txttenloaikh";
            this.txttenloaikh.Size = new System.Drawing.Size(232, 20);
            this.txttenloaikh.TabIndex = 0;
            // 
            // lbltenloaikh
            // 
            this.lbltenloaikh.AutoSize = true;
            this.lbltenloaikh.Location = new System.Drawing.Point(16, 30);
            this.lbltenloaikh.Name = "lbltenloaikh";
            this.lbltenloaikh.Size = new System.Drawing.Size(45, 13);
            this.lbltenloaikh.TabIndex = 0;
            this.lbltenloaikh.Text = "Tên loại";
            // 
            // gbchucnangloaikh
            // 
            this.gbchucnangloaikh.Controls.Add(this.btnchitietloaikh);
            this.gbchucnangloaikh.Controls.Add(this.btndelloaikh);
            this.gbchucnangloaikh.Controls.Add(this.btneditloaikh);
            this.gbchucnangloaikh.Controls.Add(this.btnaddloaikh);
            this.gbchucnangloaikh.Location = new System.Drawing.Point(12, 12);
            this.gbchucnangloaikh.Name = "gbchucnangloaikh";
            this.gbchucnangloaikh.Size = new System.Drawing.Size(375, 65);
            this.gbchucnangloaikh.TabIndex = 1;
            this.gbchucnangloaikh.TabStop = false;
            this.gbchucnangloaikh.Text = "Chức năng";
            // 
            // btnchitietloaikh
            // 
            this.btnchitietloaikh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchitietloaikh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnchitietloaikh.Location = new System.Drawing.Point(281, 25);
            this.btnchitietloaikh.Name = "btnchitietloaikh";
            this.btnchitietloaikh.Size = new System.Drawing.Size(75, 23);
            this.btnchitietloaikh.TabIndex = 3;
            this.btnchitietloaikh.Text = "Chi tiết";
            this.btnchitietloaikh.UseVisualStyleBackColor = true;
            // 
            // btndelloaikh
            // 
            this.btndelloaikh.BackColor = System.Drawing.Color.White;
            this.btndelloaikh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelloaikh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndelloaikh.Location = new System.Drawing.Point(194, 25);
            this.btndelloaikh.Name = "btndelloaikh";
            this.btndelloaikh.Size = new System.Drawing.Size(75, 23);
            this.btndelloaikh.TabIndex = 2;
            this.btndelloaikh.Text = "Xóa";
            this.btndelloaikh.UseVisualStyleBackColor = false;
            // 
            // btneditloaikh
            // 
            this.btneditloaikh.BackColor = System.Drawing.Color.White;
            this.btneditloaikh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditloaikh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneditloaikh.Location = new System.Drawing.Point(107, 25);
            this.btneditloaikh.Name = "btneditloaikh";
            this.btneditloaikh.Size = new System.Drawing.Size(75, 23);
            this.btneditloaikh.TabIndex = 1;
            this.btneditloaikh.Text = "Sửa";
            this.btneditloaikh.UseVisualStyleBackColor = false;
            // 
            // btnaddloaikh
            // 
            this.btnaddloaikh.BackColor = System.Drawing.Color.White;
            this.btnaddloaikh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddloaikh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnaddloaikh.Location = new System.Drawing.Point(20, 25);
            this.btnaddloaikh.Name = "btnaddloaikh";
            this.btnaddloaikh.Size = new System.Drawing.Size(75, 23);
            this.btnaddloaikh.TabIndex = 0;
            this.btnaddloaikh.Text = "Thêm mới";
            this.btnaddloaikh.UseVisualStyleBackColor = false;
            // 
            // floaikh
            // 
            this.AcceptButton = this.btnaddloaikh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 359);
            this.Controls.Add(this.gbthongtinloaikh);
            this.Controls.Add(this.gbchucnangloaikh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "floaikh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại khách hàng";
            this.gbthongtinloaikh.ResumeLayout(false);
            this.gbthongtinloaikh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsloaikh)).EndInit();
            this.gbchucnangloaikh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbthongtinloaikh;
        private System.Windows.Forms.DataGridView dtgdsloaikh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaikh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idloaikh;
        private System.Windows.Forms.TextBox txttenloaikh;
        private System.Windows.Forms.Label lbltenloaikh;
        private System.Windows.Forms.GroupBox gbchucnangloaikh;
        private System.Windows.Forms.Button btnchitietloaikh;
        private System.Windows.Forms.Button btndelloaikh;
        private System.Windows.Forms.Button btneditloaikh;
        private System.Windows.Forms.Button btnaddloaikh;
    }
}