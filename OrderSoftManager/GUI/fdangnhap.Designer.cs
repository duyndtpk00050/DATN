namespace OrderSoftManager
{
    partial class fdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fdangnhap));
            this.gbdn = new System.Windows.Forms.GroupBox();
            this.btnquenmk = new System.Windows.Forms.Button();
            this.btndn = new System.Windows.Forms.Button();
            this.chbghinho = new System.Windows.Forms.CheckBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.lblmk = new System.Windows.Forms.Label();
            this.lbltendn = new System.Windows.Forms.Label();
            this.piclogin = new System.Windows.Forms.PictureBox();
            this.gbdn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdn
            // 
            this.gbdn.Controls.Add(this.btnquenmk);
            this.gbdn.Controls.Add(this.btndn);
            this.gbdn.Controls.Add(this.chbghinho);
            this.gbdn.Controls.Add(this.txtmk);
            this.gbdn.Controls.Add(this.txttendn);
            this.gbdn.Controls.Add(this.lblmk);
            this.gbdn.Controls.Add(this.lbltendn);
            this.gbdn.Location = new System.Drawing.Point(195, 12);
            this.gbdn.Name = "gbdn";
            this.gbdn.Size = new System.Drawing.Size(300, 174);
            this.gbdn.TabIndex = 0;
            this.gbdn.TabStop = false;
            this.gbdn.Text = "Đăng nhập hệ thống";
            // 
            // btnquenmk
            // 
            this.btnquenmk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquenmk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnquenmk.Location = new System.Drawing.Point(182, 133);
            this.btnquenmk.Name = "btnquenmk";
            this.btnquenmk.Size = new System.Drawing.Size(101, 23);
            this.btnquenmk.TabIndex = 5;
            this.btnquenmk.Text = "Quên mật khẩu";
            this.btnquenmk.UseVisualStyleBackColor = true;
            // 
            // btndn
            // 
            this.btndn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndn.Location = new System.Drawing.Point(101, 133);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(75, 23);
            this.btndn.TabIndex = 4;
            this.btndn.Text = "Đăng nhập";
            this.btndn.UseVisualStyleBackColor = true;
            // 
            // chbghinho
            // 
            this.chbghinho.AutoSize = true;
            this.chbghinho.ForeColor = System.Drawing.Color.Gray;
            this.chbghinho.Location = new System.Drawing.Point(101, 102);
            this.chbghinho.Name = "chbghinho";
            this.chbghinho.Size = new System.Drawing.Size(172, 17);
            this.chbghinho.TabIndex = 3;
            this.chbghinho.Text = "Ghi nhớ tài khoản và mật khẩu";
            this.chbghinho.UseVisualStyleBackColor = true;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(101, 68);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(182, 20);
            this.txtmk.TabIndex = 1;
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(101, 34);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(182, 20);
            this.txttendn.TabIndex = 0;
            // 
            // lblmk
            // 
            this.lblmk.AutoSize = true;
            this.lblmk.Location = new System.Drawing.Point(43, 72);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(52, 13);
            this.lblmk.TabIndex = 1;
            this.lblmk.Text = "Mật khẩu";
            // 
            // lbltendn
            // 
            this.lbltendn.AutoSize = true;
            this.lbltendn.Location = new System.Drawing.Point(14, 38);
            this.lbltendn.Name = "lbltendn";
            this.lbltendn.Size = new System.Drawing.Size(81, 13);
            this.lbltendn.TabIndex = 0;
            this.lbltendn.Text = "Tên đăng nhập";
            // 
            // piclogin
            // 
            this.piclogin.Image = global::OrderSoftManager.Properties.Resources.login;
            this.piclogin.Location = new System.Drawing.Point(12, 16);
            this.piclogin.Name = "piclogin";
            this.piclogin.Size = new System.Drawing.Size(177, 170);
            this.piclogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogin.TabIndex = 2;
            this.piclogin.TabStop = false;
            // 
            // fdangnhap
            // 
            this.AcceptButton = this.btndn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 202);
            this.Controls.Add(this.piclogin);
            this.Controls.Add(this.gbdn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý bán hàng Phong Vân";
            this.gbdn.ResumeLayout(false);
            this.gbdn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdn;
        private System.Windows.Forms.Button btnquenmk;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.CheckBox chbghinho;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.Label lblmk;
        private System.Windows.Forms.Label lbltendn;
        private System.Windows.Forms.PictureBox piclogin;
    }
}