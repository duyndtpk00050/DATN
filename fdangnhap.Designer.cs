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
            this.cbghinho = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblmk = new System.Windows.Forms.Label();
            this.lbltennvdn = new System.Windows.Forms.Label();
            this.pblogin = new System.Windows.Forms.PictureBox();
            this.gbdn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdn
            // 
            this.gbdn.Controls.Add(this.btnquenmk);
            this.gbdn.Controls.Add(this.btndn);
            this.gbdn.Controls.Add(this.cbghinho);
            this.gbdn.Controls.Add(this.textBox2);
            this.gbdn.Controls.Add(this.textBox1);
            this.gbdn.Controls.Add(this.lblmk);
            this.gbdn.Controls.Add(this.lbltennvdn);
            this.gbdn.Location = new System.Drawing.Point(195, 12);
            this.gbdn.Name = "gbdn";
            this.gbdn.Size = new System.Drawing.Size(300, 174);
            this.gbdn.TabIndex = 1;
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
            // cbghinho
            // 
            this.cbghinho.AutoSize = true;
            this.cbghinho.ForeColor = System.Drawing.Color.Gray;
            this.cbghinho.Location = new System.Drawing.Point(101, 102);
            this.cbghinho.Name = "cbghinho";
            this.cbghinho.Size = new System.Drawing.Size(172, 17);
            this.cbghinho.TabIndex = 3;
            this.cbghinho.Text = "Ghi nhớ tài khoản và mật khẩu";
            this.cbghinho.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 0;
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
            // lbltennvdn
            // 
            this.lbltennvdn.AutoSize = true;
            this.lbltennvdn.Location = new System.Drawing.Point(14, 38);
            this.lbltennvdn.Name = "lbltennvdn";
            this.lbltennvdn.Size = new System.Drawing.Size(81, 13);
            this.lbltennvdn.TabIndex = 0;
            this.lbltennvdn.Text = "Tên đăng nhập";
            // 
            // pblogin
            // 
            this.pblogin.Image = global::OrderSoftManager.Properties.Resources.login;
            this.pblogin.Location = new System.Drawing.Point(12, 16);
            this.pblogin.Name = "pblogin";
            this.pblogin.Size = new System.Drawing.Size(177, 170);
            this.pblogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogin.TabIndex = 2;
            this.pblogin.TabStop = false;
            // 
            // fdangnhap
            // 
            this.AcceptButton = this.btndn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 202);
            this.Controls.Add(this.pblogin);
            this.Controls.Add(this.gbdn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý bán hàng Phong Vân";
            this.gbdn.ResumeLayout(false);
            this.gbdn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdn;
        private System.Windows.Forms.Button btnquenmk;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.CheckBox cbghinho;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblmk;
        private System.Windows.Forms.Label lbltennvdn;
        private System.Windows.Forms.PictureBox pblogin;
    }
}