namespace coffe_otomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGiris = new System.Windows.Forms.CheckBox();
            this.cbKayit = new System.Windows.Forms.CheckBox();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(282, 108);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(250, 33);
            this.txtUser.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(282, 147);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(250, 31);
            this.txtPwd.TabIndex = 2;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(436, 188);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(91, 41);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "Giriş yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.Location = new System.Drawing.Point(436, 247);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(91, 43);
            this.btn_kayıt.TabIndex = 4;
            this.btn_kayıt.Text = "Kayıt ol";
            this.btn_kayıt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(193, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giriş ";
            // 
            // cbGiris
            // 
            this.cbGiris.AutoSize = true;
            this.cbGiris.Checked = true;
            this.cbGiris.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGiris.Location = new System.Drawing.Point(297, 314);
            this.cbGiris.Name = "cbGiris";
            this.cbGiris.Size = new System.Drawing.Size(104, 28);
            this.cbGiris.TabIndex = 8;
            this.cbGiris.Text = "Giriş Yap";
            this.cbGiris.UseVisualStyleBackColor = true;
            this.cbGiris.CheckedChanged += new System.EventHandler(this.cbGiris_CheckedChanged);
            // 
            // cbKayit
            // 
            this.cbKayit.AutoSize = true;
            this.cbKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKayit.Location = new System.Drawing.Point(435, 314);
            this.cbKayit.Name = "cbKayit";
            this.cbKayit.Size = new System.Drawing.Size(92, 28);
            this.cbKayit.TabIndex = 9;
            this.cbKayit.Text = "Kayıt Ol";
            this.cbKayit.UseVisualStyleBackColor = true;
            this.cbKayit.CheckedChanged += new System.EventHandler(this.cbKayit_CheckedChanged);
            // 
            // txtSifre2
            // 
            this.txtSifre2.Location = new System.Drawing.Point(282, 188);
            this.txtSifre2.Multiline = true;
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.Size = new System.Drawing.Size(250, 31);
            this.txtSifre2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(116, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parola Tekrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cbKayit);
            this.Controls.Add(this.cbGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayıt);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txtSifre2);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbGiris;
        private System.Windows.Forms.CheckBox cbKayit;
        private System.Windows.Forms.TextBox txtSifre2;
        private System.Windows.Forms.Label label4;
    }
}

