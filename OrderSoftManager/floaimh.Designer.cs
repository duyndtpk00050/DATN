﻿namespace OrderSoftManager
{
    partial class floaimh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(floaimh));
            this.gbthongtinloaimh = new System.Windows.Forms.GroupBox();
            this.dtgdsloaimh = new System.Windows.Forms.DataGridView();
            this.sttloaimh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaimh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idloaimh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttencl = new System.Windows.Forms.TextBox();
            this.lbltenloaimh = new System.Windows.Forms.Label();
            this.gbchucnangcl = new System.Windows.Forms.GroupBox();
            this.btnchitietloaimh = new System.Windows.Forms.Button();
            this.btndelloaimh = new System.Windows.Forms.Button();
            this.btneditloaimh = new System.Windows.Forms.Button();
            this.btnaddloaimh = new System.Windows.Forms.Button();
            this.gbthongtinloaimh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsloaimh)).BeginInit();
            this.gbchucnangcl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbthongtinloaimh
            // 
            this.gbthongtinloaimh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbthongtinloaimh.Controls.Add(this.dtgdsloaimh);
            this.gbthongtinloaimh.Controls.Add(this.txttencl);
            this.gbthongtinloaimh.Controls.Add(this.lbltenloaimh);
            this.gbthongtinloaimh.Location = new System.Drawing.Point(133, 12);
            this.gbthongtinloaimh.Name = "gbthongtinloaimh";
            this.gbthongtinloaimh.Size = new System.Drawing.Size(265, 172);
            this.gbthongtinloaimh.TabIndex = 0;
            this.gbthongtinloaimh.TabStop = false;
            this.gbthongtinloaimh.Text = "Danh sách loai mặt hàng";
            // 
            // dtgdsloaimh
            // 
            this.dtgdsloaimh.AllowUserToResizeRows = false;
            this.dtgdsloaimh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdsloaimh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgdsloaimh.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgdsloaimh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdsloaimh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgdsloaimh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgdsloaimh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgdsloaimh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttloaimh,
            this.tenloaimh,
            this.idloaimh});
            this.dtgdsloaimh.EnableHeadersVisualStyles = false;
            this.dtgdsloaimh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgdsloaimh.Location = new System.Drawing.Point(6, 61);
            this.dtgdsloaimh.Name = "dtgdsloaimh";
            this.dtgdsloaimh.ReadOnly = true;
            this.dtgdsloaimh.RowHeadersVisible = false;
            this.dtgdsloaimh.Size = new System.Drawing.Size(253, 105);
            this.dtgdsloaimh.TabIndex = 3;
            // 
            // sttloaimh
            // 
            this.sttloaimh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sttloaimh.HeaderText = "STT";
            this.sttloaimh.Name = "sttloaimh";
            this.sttloaimh.ReadOnly = true;
            this.sttloaimh.Width = 53;
            // 
            // tenloaimh
            // 
            this.tenloaimh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenloaimh.HeaderText = "Loại mặt hàng";
            this.tenloaimh.Name = "tenloaimh";
            this.tenloaimh.ReadOnly = true;
            this.tenloaimh.Width = 99;
            // 
            // idloaimh
            // 
            this.idloaimh.HeaderText = "idloaimh";
            this.idloaimh.Name = "idloaimh";
            this.idloaimh.ReadOnly = true;
            this.idloaimh.Visible = false;
            this.idloaimh.Width = 70;
            // 
            // txttencl
            // 
            this.txttencl.Location = new System.Drawing.Point(93, 25);
            this.txttencl.Name = "txttencl";
            this.txttencl.Size = new System.Drawing.Size(159, 20);
            this.txttencl.TabIndex = 0;
            // 
            // lbltenloaimh
            // 
            this.lbltenloaimh.AutoSize = true;
            this.lbltenloaimh.Location = new System.Drawing.Point(13, 28);
            this.lbltenloaimh.Name = "lbltenloaimh";
            this.lbltenloaimh.Size = new System.Drawing.Size(74, 13);
            this.lbltenloaimh.TabIndex = 0;
            this.lbltenloaimh.Text = "Loại mặt hàng";
            // 
            // gbchucnangcl
            // 
            this.gbchucnangcl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbchucnangcl.Controls.Add(this.btnchitietloaimh);
            this.gbchucnangcl.Controls.Add(this.btndelloaimh);
            this.gbchucnangcl.Controls.Add(this.btneditloaimh);
            this.gbchucnangcl.Controls.Add(this.btnaddloaimh);
            this.gbchucnangcl.Location = new System.Drawing.Point(12, 12);
            this.gbchucnangcl.Name = "gbchucnangcl";
            this.gbchucnangcl.Size = new System.Drawing.Size(115, 172);
            this.gbchucnangcl.TabIndex = 1;
            this.gbchucnangcl.TabStop = false;
            this.gbchucnangcl.Text = "Chức năng";
            // 
            // btnchitietloaimh
            // 
            this.btnchitietloaimh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchitietloaimh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnchitietloaimh.Location = new System.Drawing.Point(19, 133);
            this.btnchitietloaimh.Name = "btnchitietloaimh";
            this.btnchitietloaimh.Size = new System.Drawing.Size(75, 23);
            this.btnchitietloaimh.TabIndex = 3;
            this.btnchitietloaimh.Text = "Chi tiết";
            this.btnchitietloaimh.UseVisualStyleBackColor = true;
            // 
            // btndelloaimh
            // 
            this.btndelloaimh.BackColor = System.Drawing.Color.White;
            this.btndelloaimh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelloaimh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndelloaimh.Location = new System.Drawing.Point(19, 97);
            this.btndelloaimh.Name = "btndelloaimh";
            this.btndelloaimh.Size = new System.Drawing.Size(75, 23);
            this.btndelloaimh.TabIndex = 2;
            this.btndelloaimh.Text = "Xóa";
            this.btndelloaimh.UseVisualStyleBackColor = false;
            // 
            // btneditloaimh
            // 
            this.btneditloaimh.BackColor = System.Drawing.Color.White;
            this.btneditloaimh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditloaimh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneditloaimh.Location = new System.Drawing.Point(19, 61);
            this.btneditloaimh.Name = "btneditloaimh";
            this.btneditloaimh.Size = new System.Drawing.Size(75, 23);
            this.btneditloaimh.TabIndex = 1;
            this.btneditloaimh.Text = "Sửa";
            this.btneditloaimh.UseVisualStyleBackColor = false;
            // 
            // btnaddloaimh
            // 
            this.btnaddloaimh.BackColor = System.Drawing.Color.White;
            this.btnaddloaimh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddloaimh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnaddloaimh.Location = new System.Drawing.Point(19, 25);
            this.btnaddloaimh.Name = "btnaddloaimh";
            this.btnaddloaimh.Size = new System.Drawing.Size(75, 23);
            this.btnaddloaimh.TabIndex = 0;
            this.btnaddloaimh.Text = "Mới \\ Thêm";
            this.btnaddloaimh.UseVisualStyleBackColor = false;
            // 
            // floaimh
            // 
            this.AcceptButton = this.btnaddloaimh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 196);
            this.Controls.Add(this.gbthongtinloaimh);
            this.Controls.Add(this.gbchucnangcl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "floaimh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại mặt hàng";
            this.gbthongtinloaimh.ResumeLayout(false);
            this.gbthongtinloaimh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsloaimh)).EndInit();
            this.gbchucnangcl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbthongtinloaimh;
        private System.Windows.Forms.DataGridView dtgdsloaimh;
        private System.Windows.Forms.TextBox txttencl;
        private System.Windows.Forms.Label lbltenloaimh;
        private System.Windows.Forms.GroupBox gbchucnangcl;
        private System.Windows.Forms.Button btnchitietloaimh;
        private System.Windows.Forms.Button btndelloaimh;
        private System.Windows.Forms.Button btneditloaimh;
        private System.Windows.Forms.Button btnaddloaimh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttloaimh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaimh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idloaimh;
    }
}