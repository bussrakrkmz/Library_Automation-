namespace Library__Automation
{
    partial class Form2
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Signup = new System.Windows.Forms.Button();
            this.pnl_signin = new System.Windows.Forms.Panel();
            this.pnl_signup = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.departman = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_signin.SuspendLayout();
            this.pnl_signup.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserName.Location = new System.Drawing.Point(178, 104);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(126, 29);
            this.UserName.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Password.Location = new System.Drawing.Point(178, 153);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(126, 29);
            this.Password.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Firebrick;
            this.Login.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(77, 253);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(154, 46);
            this.Login.TabIndex = 7;
            this.Login.Text = "Giriş Yap";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click_1);
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.Teal;
            this.Signup.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.ForeColor = System.Drawing.Color.White;
            this.Signup.Location = new System.Drawing.Point(14, 26);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(273, 43);
            this.Signup.TabIndex = 8;
            this.Signup.Text = "Üye Olmak İçin Tıkla! ";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // pnl_signin
            // 
            this.pnl_signin.BackColor = System.Drawing.Color.Transparent;
            this.pnl_signin.Controls.Add(this.Signup);
            this.pnl_signin.Controls.Add(this.Login);
            this.pnl_signin.Controls.Add(this.label2);
            this.pnl_signin.Controls.Add(this.label1);
            this.pnl_signin.Controls.Add(this.Password);
            this.pnl_signin.Controls.Add(this.UserName);
            this.pnl_signin.Location = new System.Drawing.Point(12, 8);
            this.pnl_signin.Name = "pnl_signin";
            this.pnl_signin.Size = new System.Drawing.Size(308, 299);
            this.pnl_signin.TabIndex = 9;
            // 
            // pnl_signup
            // 
            this.pnl_signup.BackColor = System.Drawing.Color.Transparent;
            this.pnl_signup.Controls.Add(this.back);
            this.pnl_signup.Controls.Add(this.button1);
            this.pnl_signup.Controls.Add(this.departman);
            this.pnl_signup.Controls.Add(this.pass);
            this.pnl_signup.Controls.Add(this.Email);
            this.pnl_signup.Controls.Add(this.uname);
            this.pnl_signup.Controls.Add(this.name);
            this.pnl_signup.Controls.Add(this.label7);
            this.pnl_signup.Controls.Add(this.label6);
            this.pnl_signup.Controls.Add(this.label5);
            this.pnl_signup.Controls.Add(this.label4);
            this.pnl_signup.Controls.Add(this.label3);
            this.pnl_signup.Location = new System.Drawing.Point(35, 313);
            this.pnl_signup.Name = "pnl_signup";
            this.pnl_signup.Size = new System.Drawing.Size(229, 22);
            this.pnl_signup.TabIndex = 10;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.back.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(227, 304);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(67, 31);
            this.back.TabIndex = 16;
            this.back.Text = "Geri";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(94, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Üye Ol!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // departman
            // 
            this.departman.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departman.Location = new System.Drawing.Point(159, 221);
            this.departman.Name = "departman";
            this.departman.Size = new System.Drawing.Size(135, 25);
            this.departman.TabIndex = 14;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(159, 177);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(135, 25);
            this.pass.TabIndex = 13;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(159, 130);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(135, 25);
            this.Email.TabIndex = 12;
            // 
            // uname
            // 
            this.uname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(159, 88);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(135, 25);
            this.uname.TabIndex = 11;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(159, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 25);
            this.name.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Departman:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kullanıcı Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImage = global::Library__Automation.Properties.Resources.r;
            this.ClientSize = new System.Drawing.Size(321, 347);
            this.Controls.Add(this.pnl_signup);
            this.Controls.Add(this.pnl_signin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Automation";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl_signin.ResumeLayout(false);
            this.pnl_signin.PerformLayout();
            this.pnl_signup.ResumeLayout(false);
            this.pnl_signup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Panel pnl_signin;
        private System.Windows.Forms.Panel pnl_signup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox departman;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back;
    }
}