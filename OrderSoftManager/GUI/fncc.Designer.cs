namespace QLBanHang
{
    partial class fncc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fncc));
            this.gbchucnangncc = new System.Windows.Forms.GroupBox();
            this.btndelncc = new System.Windows.Forms.Button();
            this.btneditncc = new System.Windows.Forms.Button();
            this.btnaddncc = new System.Windows.Forms.Button();
            this.btnrefreshncc = new System.Windows.Forms.Button();
            this.gbthongtinncc = new System.Windows.Forms.GroupBox();
            this.txtfaxncc = new System.Windows.Forms.TextBox();
            this.txtsdtncc = new System.Windows.Forms.TextBox();
            this.txtmailncc = new System.Windows.Forms.TextBox();
            this.txtdiachincc = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.lblsdtncc = new System.Windows.Forms.Label();
            this.lblfaxncc = new System.Windows.Forms.Label();
            this.lblmailncc = new System.Windows.Forms.Label();
            this.lbldiachincc = new System.Windows.Forms.Label();
            this.lbltenncc = new System.Windows.Forms.Label();
            this.gbdsncc = new System.Windows.Forms.GroupBox();
            this.dtgdsncc = new System.Windows.Forms.DataGridView();
            this.sttncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachincc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sofaxncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbchucnangncc.SuspendLayout();
            this.gbthongtinncc.SuspendLayout();
            this.gbdsncc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsncc)).BeginInit();
            this.SuspendLayout();
            // 
            // gbchucnangncc
            // 
            this.gbchucnangncc.Controls.Add(this.btndelncc);
            this.gbchucnangncc.Controls.Add(this.btneditncc);
            this.gbchucnangncc.Controls.Add(this.btnaddncc);
            this.gbchucnangncc.Controls.Add(this.btnrefreshncc);
            this.gbchucnangncc.Location = new System.Drawing.Point(12, 12);
            this.gbchucnangncc.Name = "gbchucnangncc";
            this.gbchucnangncc.Size = new System.Drawing.Size(387, 65);
            this.gbchucnangncc.TabIndex = 1;
            this.gbchucnangncc.TabStop = false;
            this.gbchucnangncc.Text = "Chức năng";
            // 
            // btndelncc
            // 
            this.btndelncc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelncc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndelncc.Location = new System.Drawing.Point(289, 25);
            this.btndelncc.Name = "btndelncc";
            this.btndelncc.Size = new System.Drawing.Size(78, 23);
            this.btndelncc.TabIndex = 3;
            this.btndelncc.Text = "Xóa";
            this.btndelncc.UseVisualStyleBackColor = true;
            // 
            // btneditncc
            // 
            this.btneditncc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditncc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneditncc.Location = new System.Drawing.Point(199, 25);
            this.btneditncc.Name = "btneditncc";
            this.btneditncc.Size = new System.Drawing.Size(78, 23);
            this.btneditncc.TabIndex = 2;
            this.btneditncc.Text = "Sửa";
            this.btneditncc.UseVisualStyleBackColor = true;
            // 
            // btnaddncc
            // 
            this.btnaddncc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddncc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnaddncc.Location = new System.Drawing.Point(109, 25);
            this.btnaddncc.Name = "btnaddncc";
            this.btnaddncc.Size = new System.Drawing.Size(78, 23);
            this.btnaddncc.TabIndex = 1;
            this.btnaddncc.Text = "Thêm";
            this.btnaddncc.UseVisualStyleBackColor = true;
            // 
            // btnrefreshncc
            // 
            this.btnrefreshncc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefreshncc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnrefreshncc.Location = new System.Drawing.Point(19, 25);
            this.btnrefreshncc.Name = "btnrefreshncc";
            this.btnrefreshncc.Size = new System.Drawing.Size(78, 23);
            this.btnrefreshncc.TabIndex = 0;
            this.btnrefreshncc.Text = "Làm mới";
            this.btnrefreshncc.UseVisualStyleBackColor = true;
            // 
            // gbthongtinncc
            // 
            this.gbthongtinncc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbthongtinncc.Controls.Add(this.txtfaxncc);
            this.gbthongtinncc.Controls.Add(this.txtsdtncc);
            this.gbthongtinncc.Controls.Add(this.txtmailncc);
            this.gbthongtinncc.Controls.Add(this.txtdiachincc);
            this.gbthongtinncc.Controls.Add(this.txttenncc);
            this.gbthongtinncc.Controls.Add(this.lblsdtncc);
            this.gbthongtinncc.Controls.Add(this.lblfaxncc);
            this.gbthongtinncc.Controls.Add(this.lblmailncc);
            this.gbthongtinncc.Controls.Add(this.lbldiachincc);
            this.gbthongtinncc.Controls.Add(this.lbltenncc);
            this.gbthongtinncc.Location = new System.Drawing.Point(12, 83);
            this.gbthongtinncc.Name = "gbthongtinncc";
            this.gbthongtinncc.Size = new System.Drawing.Size(387, 279);
            this.gbthongtinncc.TabIndex = 0;
            this.gbthongtinncc.TabStop = false;
            this.gbthongtinncc.Text = "Thông tin";
            // 
            // txtfaxncc
            // 
            this.txtfaxncc.Location = new System.Drawing.Point(127, 238);
            this.txtfaxncc.Name = "txtfaxncc";
            this.txtfaxncc.Size = new System.Drawing.Size(238, 20);
            this.txtfaxncc.TabIndex = 4;
            // 
            // txtsdtncc
            // 
            this.txtsdtncc.Location = new System.Drawing.Point(127, 197);
            this.txtsdtncc.Name = "txtsdtncc";
            this.txtsdtncc.Size = new System.Drawing.Size(238, 20);
            this.txtsdtncc.TabIndex = 3;
            // 
            // txtmailncc
            // 
            this.txtmailncc.Location = new System.Drawing.Point(127, 156);
            this.txtmailncc.Name = "txtmailncc";
            this.txtmailncc.Size = new System.Drawing.Size(238, 20);
            this.txtmailncc.TabIndex = 2;
            // 
            // txtdiachincc
            // 
            this.txtdiachincc.Location = new System.Drawing.Point(127, 69);
            this.txtdiachincc.Multiline = true;
            this.txtdiachincc.Name = "txtdiachincc";
            this.txtdiachincc.Size = new System.Drawing.Size(238, 66);
            this.txtdiachincc.TabIndex = 1;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(127, 28);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(238, 20);
            this.txttenncc.TabIndex = 0;
            // 
            // lblsdtncc
            // 
            this.lblsdtncc.AutoSize = true;
            this.lblsdtncc.Location = new System.Drawing.Point(39, 201);
            this.lblsdtncc.Name = "lblsdtncc";
            this.lblsdtncc.Size = new System.Drawing.Size(70, 13);
            this.lblsdtncc.TabIndex = 7;
            this.lblsdtncc.Text = "Số điện thoại";
            // 
            // lblfaxncc
            // 
            this.lblfaxncc.AutoSize = true;
            this.lblfaxncc.Location = new System.Drawing.Point(85, 242);
            this.lblfaxncc.Name = "lblfaxncc";
            this.lblfaxncc.Size = new System.Drawing.Size(24, 13);
            this.lblfaxncc.TabIndex = 6;
            this.lblfaxncc.Text = "Fax";
            // 
            // lblmailncc
            // 
            this.lblmailncc.AutoSize = true;
            this.lblmailncc.Location = new System.Drawing.Point(77, 160);
            this.lblmailncc.Name = "lblmailncc";
            this.lblmailncc.Size = new System.Drawing.Size(32, 13);
            this.lblmailncc.TabIndex = 5;
            this.lblmailncc.Text = "Email";
            // 
            // lbldiachincc
            // 
            this.lbldiachincc.AutoSize = true;
            this.lbldiachincc.Location = new System.Drawing.Point(69, 77);
            this.lbldiachincc.Name = "lbldiachincc";
            this.lbldiachincc.Size = new System.Drawing.Size(40, 13);
            this.lbldiachincc.TabIndex = 4;
            this.lbldiachincc.Text = "Địa chỉ";
            // 
            // lbltenncc
            // 
            this.lbltenncc.AutoSize = true;
            this.lbltenncc.Location = new System.Drawing.Point(14, 32);
            this.lbltenncc.Name = "lbltenncc";
            this.lbltenncc.Size = new System.Drawing.Size(95, 13);
            this.lbltenncc.TabIndex = 3;
            this.lbltenncc.Text = "Tên nhà cung cấp";
            // 
            // gbdsncc
            // 
            this.gbdsncc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbdsncc.Controls.Add(this.dtgdsncc);
            this.gbdsncc.Location = new System.Drawing.Point(405, 12);
            this.gbdsncc.Name = "gbdsncc";
            this.gbdsncc.Size = new System.Drawing.Size(383, 350);
            this.gbdsncc.TabIndex = 2;
            this.gbdsncc.TabStop = false;
            this.gbdsncc.Text = "Danh sách nhà cung cấp";
            // 
            // dtgdsncc
            // 
            this.dtgdsncc.AllowUserToResizeRows = false;
            this.dtgdsncc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdsncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgdsncc.BackgroundColor = System.Drawing.Color.White;
            this.dtgdsncc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdsncc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgdsncc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgdsncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgdsncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttncc,
            this.tenncc,
            this.diachincc,
            this.mailncc,
            this.sdtncc,
            this.sofaxncc});
            this.dtgdsncc.EnableHeadersVisualStyles = false;
            this.dtgdsncc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgdsncc.Location = new System.Drawing.Point(6, 19);
            this.dtgdsncc.Name = "dtgdsncc";
            this.dtgdsncc.ReadOnly = true;
            this.dtgdsncc.RowHeadersVisible = false;
            this.dtgdsncc.Size = new System.Drawing.Size(371, 325);
            this.dtgdsncc.TabIndex = 0;
            // 
            // sttncc
            // 
            this.sttncc.HeaderText = "STT";
            this.sttncc.Name = "sttncc";
            this.sttncc.ReadOnly = true;
            this.sttncc.Width = 52;
            // 
            // tenncc
            // 
            this.tenncc.HeaderText = "Tên";
            this.tenncc.Name = "tenncc";
            this.tenncc.ReadOnly = true;
            this.tenncc.Width = 50;
            // 
            // diachincc
            // 
            this.diachincc.HeaderText = "Địa chỉ";
            this.diachincc.Name = "diachincc";
            this.diachincc.ReadOnly = true;
            this.diachincc.Width = 64;
            // 
            // mailncc
            // 
            this.mailncc.HeaderText = "Email";
            this.mailncc.Name = "mailncc";
            this.mailncc.ReadOnly = true;
            this.mailncc.Width = 56;
            // 
            // sdtncc
            // 
            this.sdtncc.HeaderText = "Số điện thoại";
            this.sdtncc.Name = "sdtncc";
            this.sdtncc.ReadOnly = true;
            this.sdtncc.Width = 94;
            // 
            // sofaxncc
            // 
            this.sofaxncc.HeaderText = "Fax";
            this.sofaxncc.Name = "sofaxncc";
            this.sofaxncc.ReadOnly = true;
            this.sofaxncc.Width = 48;
            // 
            // fncc
            // 
            this.AcceptButton = this.btnaddncc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.gbdsncc);
            this.Controls.Add(this.gbthongtinncc);
            this.Controls.Add(this.gbchucnangncc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fncc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.gbchucnangncc.ResumeLayout(false);
            this.gbthongtinncc.ResumeLayout(false);
            this.gbthongtinncc.PerformLayout();
            this.gbdsncc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsncc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbchucnangncc;
        private System.Windows.Forms.Button btndelncc;
        private System.Windows.Forms.Button btneditncc;
        private System.Windows.Forms.Button btnaddncc;
        private System.Windows.Forms.Button btnrefreshncc;
        private System.Windows.Forms.GroupBox gbthongtinncc;
        private System.Windows.Forms.GroupBox gbdsncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachincc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sofaxncc;
        private System.Windows.Forms.DataGridView dtgdsncc;
        private System.Windows.Forms.TextBox txtfaxncc;
        private System.Windows.Forms.TextBox txtsdtncc;
        private System.Windows.Forms.TextBox txtmailncc;
        private System.Windows.Forms.TextBox txtdiachincc;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.Label lblsdtncc;
        private System.Windows.Forms.Label lblfaxncc;
        private System.Windows.Forms.Label lblmailncc;
        private System.Windows.Forms.Label lbldiachincc;
        private System.Windows.Forms.Label lbltenncc;
    }
}