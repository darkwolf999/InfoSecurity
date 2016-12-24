namespace InfoSecuritySoft
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_key_AES = new System.Windows.Forms.TextBox();
            this.textBox_text_AES = new System.Windows.Forms.TextBox();
            this.button_decrypt_AES = new System.Windows.Forms.Button();
            this.button_encrypt_AES = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_hash = new System.Windows.Forms.TextBox();
            this.textBox_text_MD5 = new System.Windows.Forms.TextBox();
            this.button_hash = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_p_RSA = new System.Windows.Forms.TextBox();
            this.button_decrypt_RSA = new System.Windows.Forms.Button();
            this.button_encrypt_RSA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_q_RSA = new System.Windows.Forms.TextBox();
            this.textBox_text_RSA = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_p_sign_RSA = new System.Windows.Forms.TextBox();
            this.button_verify_sign = new System.Windows.Forms.Button();
            this.button_sign = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_q_sign_RSA = new System.Windows.Forms.TextBox();
            this.textBox_text_sign = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_key_AES);
            this.groupBox1.Controls.Add(this.textBox_text_AES);
            this.groupBox1.Controls.Add(this.button_decrypt_AES);
            this.groupBox1.Controls.Add(this.button_encrypt_AES);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AES 128";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Text";
            // 
            // textBox_key_AES
            // 
            this.textBox_key_AES.Location = new System.Drawing.Point(50, 60);
            this.textBox_key_AES.Name = "textBox_key_AES";
            this.textBox_key_AES.Size = new System.Drawing.Size(450, 22);
            this.textBox_key_AES.TabIndex = 7;
            this.textBox_key_AES.Text = "0x22222aaaa2222222bbbb222222aaaa22";
            // 
            // textBox_text_AES
            // 
            this.textBox_text_AES.Location = new System.Drawing.Point(50, 32);
            this.textBox_text_AES.Name = "textBox_text_AES";
            this.textBox_text_AES.Size = new System.Drawing.Size(450, 22);
            this.textBox_text_AES.TabIndex = 6;
            this.textBox_text_AES.Text = "0x11112222aaaabbbbffff99995555aaaa";
            // 
            // button_decrypt_AES
            // 
            this.button_decrypt_AES.Location = new System.Drawing.Point(288, 100);
            this.button_decrypt_AES.Name = "button_decrypt_AES";
            this.button_decrypt_AES.Size = new System.Drawing.Size(212, 58);
            this.button_decrypt_AES.TabIndex = 5;
            this.button_decrypt_AES.Text = "DECRYPT";
            this.button_decrypt_AES.UseVisualStyleBackColor = true;
            this.button_decrypt_AES.Click += new System.EventHandler(this.button_decrypt_AES_Click);
            // 
            // button_encrypt_AES
            // 
            this.button_encrypt_AES.Location = new System.Drawing.Point(50, 100);
            this.button_encrypt_AES.Name = "button_encrypt_AES";
            this.button_encrypt_AES.Size = new System.Drawing.Size(206, 58);
            this.button_encrypt_AES.TabIndex = 4;
            this.button_encrypt_AES.Text = "ENCRYPT";
            this.button_encrypt_AES.UseVisualStyleBackColor = true;
            this.button_encrypt_AES.Click += new System.EventHandler(this.button_encrypt_AES_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBox_hash);
            this.groupBox5.Controls.Add(this.textBox_text_MD5);
            this.groupBox5.Controls.Add(this.button_hash);
            this.groupBox5.Location = new System.Drawing.Point(22, 220);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(518, 177);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MD5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Text";
            // 
            // textBox_hash
            // 
            this.textBox_hash.Location = new System.Drawing.Point(50, 60);
            this.textBox_hash.Name = "textBox_hash";
            this.textBox_hash.Size = new System.Drawing.Size(450, 22);
            this.textBox_hash.TabIndex = 7;
            // 
            // textBox_text_MD5
            // 
            this.textBox_text_MD5.Location = new System.Drawing.Point(50, 32);
            this.textBox_text_MD5.Name = "textBox_text_MD5";
            this.textBox_text_MD5.Size = new System.Drawing.Size(450, 22);
            this.textBox_text_MD5.TabIndex = 6;
            this.textBox_text_MD5.Text = "Sample text";
            this.textBox_text_MD5.TextChanged += new System.EventHandler(this.textBox_text_MD5_TextChanged);
            // 
            // button_hash
            // 
            this.button_hash.Location = new System.Drawing.Point(161, 102);
            this.button_hash.Name = "button_hash";
            this.button_hash.Size = new System.Drawing.Size(212, 58);
            this.button_hash.TabIndex = 5;
            this.button_hash.Text = "HASH SUM";
            this.button_hash.UseVisualStyleBackColor = true;
            this.button_hash.Click += new System.EventHandler(this.button_hash_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_p_RSA);
            this.groupBox2.Controls.Add(this.button_decrypt_RSA);
            this.groupBox2.Controls.Add(this.button_encrypt_RSA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_q_RSA);
            this.groupBox2.Controls.Add(this.textBox_text_RSA);
            this.groupBox2.Location = new System.Drawing.Point(560, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 177);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RSA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "p";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "q";
            // 
            // textBox_p_RSA
            // 
            this.textBox_p_RSA.Location = new System.Drawing.Point(288, 60);
            this.textBox_p_RSA.Name = "textBox_p_RSA";
            this.textBox_p_RSA.Size = new System.Drawing.Size(212, 22);
            this.textBox_p_RSA.TabIndex = 12;
            this.textBox_p_RSA.Text = "73";
            // 
            // button_decrypt_RSA
            // 
            this.button_decrypt_RSA.Location = new System.Drawing.Point(288, 100);
            this.button_decrypt_RSA.Name = "button_decrypt_RSA";
            this.button_decrypt_RSA.Size = new System.Drawing.Size(212, 58);
            this.button_decrypt_RSA.TabIndex = 11;
            this.button_decrypt_RSA.Text = "DECRYPT";
            this.button_decrypt_RSA.UseVisualStyleBackColor = true;
            this.button_decrypt_RSA.Click += new System.EventHandler(this.button_decrypt_RSA_Click);
            // 
            // button_encrypt_RSA
            // 
            this.button_encrypt_RSA.Location = new System.Drawing.Point(44, 100);
            this.button_encrypt_RSA.Name = "button_encrypt_RSA";
            this.button_encrypt_RSA.Size = new System.Drawing.Size(212, 58);
            this.button_encrypt_RSA.TabIndex = 10;
            this.button_encrypt_RSA.Text = "ENCRYPT";
            this.button_encrypt_RSA.UseVisualStyleBackColor = true;
            this.button_encrypt_RSA.Click += new System.EventHandler(this.button_encrypt_RSA_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Text";
            // 
            // textBox_q_RSA
            // 
            this.textBox_q_RSA.Location = new System.Drawing.Point(44, 60);
            this.textBox_q_RSA.Name = "textBox_q_RSA";
            this.textBox_q_RSA.Size = new System.Drawing.Size(212, 22);
            this.textBox_q_RSA.TabIndex = 7;
            this.textBox_q_RSA.Text = "13";
            // 
            // textBox_text_RSA
            // 
            this.textBox_text_RSA.Location = new System.Drawing.Point(44, 32);
            this.textBox_text_RSA.Name = "textBox_text_RSA";
            this.textBox_text_RSA.Size = new System.Drawing.Size(456, 22);
            this.textBox_text_RSA.TabIndex = 6;
            this.textBox_text_RSA.Text = "Sample text";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox_p_sign_RSA);
            this.groupBox3.Controls.Add(this.button_verify_sign);
            this.groupBox3.Controls.Add(this.button_sign);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox_q_sign_RSA);
            this.groupBox3.Controls.Add(this.textBox_text_sign);
            this.groupBox3.Location = new System.Drawing.Point(560, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 177);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RSA Sign";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "p";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "q";
            // 
            // textBox_p_sign_RSA
            // 
            this.textBox_p_sign_RSA.Location = new System.Drawing.Point(288, 60);
            this.textBox_p_sign_RSA.Name = "textBox_p_sign_RSA";
            this.textBox_p_sign_RSA.Size = new System.Drawing.Size(212, 22);
            this.textBox_p_sign_RSA.TabIndex = 12;
            this.textBox_p_sign_RSA.Text = "13";
            // 
            // button_verify_sign
            // 
            this.button_verify_sign.Location = new System.Drawing.Point(288, 100);
            this.button_verify_sign.Name = "button_verify_sign";
            this.button_verify_sign.Size = new System.Drawing.Size(212, 58);
            this.button_verify_sign.TabIndex = 11;
            this.button_verify_sign.Text = "VERIFY";
            this.button_verify_sign.UseVisualStyleBackColor = true;
            this.button_verify_sign.Click += new System.EventHandler(this.button_verify_sign_Click);
            // 
            // button_sign
            // 
            this.button_sign.Location = new System.Drawing.Point(44, 100);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(212, 58);
            this.button_sign.TabIndex = 10;
            this.button_sign.Text = "SIGN";
            this.button_sign.UseVisualStyleBackColor = true;
            this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Text";
            // 
            // textBox_q_sign_RSA
            // 
            this.textBox_q_sign_RSA.Location = new System.Drawing.Point(44, 60);
            this.textBox_q_sign_RSA.Name = "textBox_q_sign_RSA";
            this.textBox_q_sign_RSA.Size = new System.Drawing.Size(212, 22);
            this.textBox_q_sign_RSA.TabIndex = 7;
            this.textBox_q_sign_RSA.Text = "73";
            // 
            // textBox_text_sign
            // 
            this.textBox_text_sign.Location = new System.Drawing.Point(44, 32);
            this.textBox_text_sign.Name = "textBox_text_sign";
            this.textBox_text_sign.Size = new System.Drawing.Size(456, 22);
            this.textBox_text_sign.TabIndex = 6;
            this.textBox_text_sign.Text = "Sample text";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1100, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Info Security Soft";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_decrypt_AES;
        private System.Windows.Forms.Button button_encrypt_AES;
        private System.Windows.Forms.TextBox textBox_key_AES;
        private System.Windows.Forms.TextBox textBox_text_AES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_hash;
        private System.Windows.Forms.TextBox textBox_text_MD5;
        private System.Windows.Forms.Button button_hash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_q_RSA;
        private System.Windows.Forms.TextBox textBox_text_RSA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_p_RSA;
        private System.Windows.Forms.Button button_decrypt_RSA;
        private System.Windows.Forms.Button button_encrypt_RSA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_p_sign_RSA;
        private System.Windows.Forms.Button button_verify_sign;
        private System.Windows.Forms.Button button_sign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_q_sign_RSA;
        private System.Windows.Forms.TextBox textBox_text_sign;
    }
}

