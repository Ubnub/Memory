namespace MemoryGame
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainGB = new System.Windows.Forms.GroupBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterGB = new System.Windows.Forms.GroupBox();
            this.RegisterBackButton = new System.Windows.Forms.Button();
            this.RegPWTB = new System.Windows.Forms.TextBox();
            this.RegPWTB2 = new System.Windows.Forms.TextBox();
            this.RegEmailTB = new System.Windows.Forms.TextBox();
            this.RegEmailLB = new System.Windows.Forms.Label();
            this.RegPasswordLB2 = new System.Windows.Forms.Label();
            this.RegUNTB = new System.Windows.Forms.TextBox();
            this.RegisterButton2 = new System.Windows.Forms.Button();
            this.RegisterErrorLB = new System.Windows.Forms.Label();
            this.RegPasswordLB = new System.Windows.Forms.Label();
            this.RegUserNameLB = new System.Windows.Forms.Label();
            this.LoginGB = new System.Windows.Forms.GroupBox();
            this.LoginBackButton = new System.Windows.Forms.Button();
            this.LoginPasswordTB = new System.Windows.Forms.TextBox();
            this.LoginUserNameTB = new System.Windows.Forms.TextBox();
            this.LoginButton2 = new System.Windows.Forms.Button();
            this.LoginErrorLB = new System.Windows.Forms.Label();
            this.LoginPWLB = new System.Windows.Forms.Label();
            this.LoginUserNameLB = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainGB.SuspendLayout();
            this.RegisterGB.SuspendLayout();
            this.LoginGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(339, 521);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainGB
            // 
            this.MainGB.Controls.Add(this.RegisterButton);
            this.MainGB.Controls.Add(this.LoginButton);
            this.MainGB.Location = new System.Drawing.Point(12, 12);
            this.MainGB.Name = "MainGB";
            this.MainGB.Size = new System.Drawing.Size(401, 480);
            this.MainGB.TabIndex = 3;
            this.MainGB.TabStop = false;
            this.MainGB.Text = "Main";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(205, 160);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(115, 77);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(84, 160);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(115, 77);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterGB
            // 
            this.RegisterGB.Controls.Add(this.RegisterBackButton);
            this.RegisterGB.Controls.Add(this.RegPWTB);
            this.RegisterGB.Controls.Add(this.RegPWTB2);
            this.RegisterGB.Controls.Add(this.RegEmailTB);
            this.RegisterGB.Controls.Add(this.RegEmailLB);
            this.RegisterGB.Controls.Add(this.RegPasswordLB2);
            this.RegisterGB.Controls.Add(this.RegUNTB);
            this.RegisterGB.Controls.Add(this.RegisterButton2);
            this.RegisterGB.Controls.Add(this.RegisterErrorLB);
            this.RegisterGB.Controls.Add(this.RegPasswordLB);
            this.RegisterGB.Controls.Add(this.RegUserNameLB);
            this.RegisterGB.Location = new System.Drawing.Point(12, 12);
            this.RegisterGB.Name = "RegisterGB";
            this.RegisterGB.Size = new System.Drawing.Size(401, 480);
            this.RegisterGB.TabIndex = 7;
            this.RegisterGB.TabStop = false;
            this.RegisterGB.Text = "Register";
            this.RegisterGB.Visible = false;
            // 
            // RegisterBackButton
            // 
            this.RegisterBackButton.Location = new System.Drawing.Point(6, 418);
            this.RegisterBackButton.Name = "RegisterBackButton";
            this.RegisterBackButton.Size = new System.Drawing.Size(136, 56);
            this.RegisterBackButton.TabIndex = 11;
            this.RegisterBackButton.Text = "Back";
            this.RegisterBackButton.UseVisualStyleBackColor = true;
            this.RegisterBackButton.Click += new System.EventHandler(this.RegisterBackButton_Click);
            // 
            // RegPWTB
            // 
            this.RegPWTB.Location = new System.Drawing.Point(111, 115);
            this.RegPWTB.Name = "RegPWTB";
            this.RegPWTB.PasswordChar = '*';
            this.RegPWTB.Size = new System.Drawing.Size(157, 20);
            this.RegPWTB.TabIndex = 10;
            this.RegPWTB.UseSystemPasswordChar = true;
            // 
            // RegPWTB2
            // 
            this.RegPWTB2.Location = new System.Drawing.Point(111, 141);
            this.RegPWTB2.Name = "RegPWTB2";
            this.RegPWTB2.PasswordChar = '*';
            this.RegPWTB2.Size = new System.Drawing.Size(157, 20);
            this.RegPWTB2.TabIndex = 9;
            this.RegPWTB2.UseSystemPasswordChar = true;
            // 
            // RegEmailTB
            // 
            this.RegEmailTB.Location = new System.Drawing.Point(111, 167);
            this.RegEmailTB.Name = "RegEmailTB";
            this.RegEmailTB.Size = new System.Drawing.Size(157, 20);
            this.RegEmailTB.TabIndex = 8;
            // 
            // RegEmailLB
            // 
            this.RegEmailLB.AutoSize = true;
            this.RegEmailLB.Location = new System.Drawing.Point(72, 170);
            this.RegEmailLB.Name = "RegEmailLB";
            this.RegEmailLB.Size = new System.Drawing.Size(32, 13);
            this.RegEmailLB.TabIndex = 7;
            this.RegEmailLB.Text = "Email";
            // 
            // RegPasswordLB2
            // 
            this.RegPasswordLB2.AutoSize = true;
            this.RegPasswordLB2.Location = new System.Drawing.Point(56, 144);
            this.RegPasswordLB2.Name = "RegPasswordLB2";
            this.RegPasswordLB2.Size = new System.Drawing.Size(48, 13);
            this.RegPasswordLB2.TabIndex = 6;
            this.RegPasswordLB2.Text = "Re-enter";
            // 
            // RegUNTB
            // 
            this.RegUNTB.Location = new System.Drawing.Point(111, 89);
            this.RegUNTB.Name = "RegUNTB";
            this.RegUNTB.Size = new System.Drawing.Size(157, 20);
            this.RegUNTB.TabIndex = 4;
            // 
            // RegisterButton2
            // 
            this.RegisterButton2.Location = new System.Drawing.Point(161, 193);
            this.RegisterButton2.Name = "RegisterButton2";
            this.RegisterButton2.Size = new System.Drawing.Size(107, 43);
            this.RegisterButton2.TabIndex = 3;
            this.RegisterButton2.Text = "Register";
            this.RegisterButton2.UseVisualStyleBackColor = true;
            this.RegisterButton2.Click += new System.EventHandler(this.RegisterButton2_Click);
            // 
            // RegisterErrorLB
            // 
            this.RegisterErrorLB.AutoSize = true;
            this.RegisterErrorLB.Location = new System.Drawing.Point(108, 67);
            this.RegisterErrorLB.Name = "RegisterErrorLB";
            this.RegisterErrorLB.Size = new System.Drawing.Size(35, 13);
            this.RegisterErrorLB.TabIndex = 2;
            this.RegisterErrorLB.Text = "label1";
            this.RegisterErrorLB.Visible = false;
            // 
            // RegPasswordLB
            // 
            this.RegPasswordLB.AutoSize = true;
            this.RegPasswordLB.Location = new System.Drawing.Point(53, 118);
            this.RegPasswordLB.Name = "RegPasswordLB";
            this.RegPasswordLB.Size = new System.Drawing.Size(53, 13);
            this.RegPasswordLB.TabIndex = 1;
            this.RegPasswordLB.Text = "Password";
            // 
            // RegUserNameLB
            // 
            this.RegUserNameLB.AutoSize = true;
            this.RegUserNameLB.Location = new System.Drawing.Point(49, 92);
            this.RegUserNameLB.Name = "RegUserNameLB";
            this.RegUserNameLB.Size = new System.Drawing.Size(57, 13);
            this.RegUserNameLB.TabIndex = 0;
            this.RegUserNameLB.Text = "UserName";
            // 
            // LoginGB
            // 
            this.LoginGB.Controls.Add(this.LoginBackButton);
            this.LoginGB.Controls.Add(this.LoginPasswordTB);
            this.LoginGB.Controls.Add(this.LoginUserNameTB);
            this.LoginGB.Controls.Add(this.LoginButton2);
            this.LoginGB.Controls.Add(this.LoginErrorLB);
            this.LoginGB.Controls.Add(this.LoginPWLB);
            this.LoginGB.Controls.Add(this.LoginUserNameLB);
            this.LoginGB.Location = new System.Drawing.Point(12, 12);
            this.LoginGB.Name = "LoginGB";
            this.LoginGB.Size = new System.Drawing.Size(401, 480);
            this.LoginGB.TabIndex = 4;
            this.LoginGB.TabStop = false;
            this.LoginGB.Text = "Login";
            this.LoginGB.Visible = false;
            // 
            // LoginBackButton
            // 
            this.LoginBackButton.Location = new System.Drawing.Point(6, 418);
            this.LoginBackButton.Name = "LoginBackButton";
            this.LoginBackButton.Size = new System.Drawing.Size(136, 56);
            this.LoginBackButton.TabIndex = 6;
            this.LoginBackButton.Text = "Back";
            this.LoginBackButton.UseVisualStyleBackColor = true;
            this.LoginBackButton.Click += new System.EventHandler(this.LoginBackButton_Click);
            // 
            // LoginPasswordTB
            // 
            this.LoginPasswordTB.Location = new System.Drawing.Point(110, 106);
            this.LoginPasswordTB.Name = "LoginPasswordTB";
            this.LoginPasswordTB.PasswordChar = '*';
            this.LoginPasswordTB.Size = new System.Drawing.Size(158, 20);
            this.LoginPasswordTB.TabIndex = 5;
            this.LoginPasswordTB.UseSystemPasswordChar = true;
            // 
            // LoginUserNameTB
            // 
            this.LoginUserNameTB.Location = new System.Drawing.Point(111, 83);
            this.LoginUserNameTB.Name = "LoginUserNameTB";
            this.LoginUserNameTB.Size = new System.Drawing.Size(157, 20);
            this.LoginUserNameTB.TabIndex = 4;
            // 
            // LoginButton2
            // 
            this.LoginButton2.Location = new System.Drawing.Point(274, 83);
            this.LoginButton2.Name = "LoginButton2";
            this.LoginButton2.Size = new System.Drawing.Size(107, 43);
            this.LoginButton2.TabIndex = 3;
            this.LoginButton2.Text = "Login";
            this.LoginButton2.UseVisualStyleBackColor = true;
            this.LoginButton2.Click += new System.EventHandler(this.LoginButton2_Click);
            // 
            // LoginErrorLB
            // 
            this.LoginErrorLB.AutoSize = true;
            this.LoginErrorLB.Location = new System.Drawing.Point(108, 144);
            this.LoginErrorLB.Name = "LoginErrorLB";
            this.LoginErrorLB.Size = new System.Drawing.Size(35, 13);
            this.LoginErrorLB.TabIndex = 2;
            this.LoginErrorLB.Text = "label3";
            this.LoginErrorLB.Visible = false;
            // 
            // LoginPWLB
            // 
            this.LoginPWLB.AutoSize = true;
            this.LoginPWLB.Location = new System.Drawing.Point(52, 109);
            this.LoginPWLB.Name = "LoginPWLB";
            this.LoginPWLB.Size = new System.Drawing.Size(53, 13);
            this.LoginPWLB.TabIndex = 1;
            this.LoginPWLB.Text = "Password";
            // 
            // LoginUserNameLB
            // 
            this.LoginUserNameLB.AutoSize = true;
            this.LoginUserNameLB.Location = new System.Drawing.Point(48, 83);
            this.LoginUserNameLB.Name = "LoginUserNameLB";
            this.LoginUserNameLB.Size = new System.Drawing.Size(57, 13);
            this.LoginUserNameLB.TabIndex = 0;
            this.LoginUserNameLB.Text = "UserName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 556);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegisterGB);
            this.Controls.Add(this.MainGB);
            this.Controls.Add(this.LoginGB);
            this.Name = "Form1";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainGB.ResumeLayout(false);
            this.RegisterGB.ResumeLayout(false);
            this.RegisterGB.PerformLayout();
            this.LoginGB.ResumeLayout(false);
            this.LoginGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox MainGB;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.GroupBox LoginGB;
        private System.Windows.Forms.TextBox LoginPasswordTB;
        private System.Windows.Forms.TextBox LoginUserNameTB;
        private System.Windows.Forms.Button LoginButton2;
        private System.Windows.Forms.Label LoginErrorLB;
        private System.Windows.Forms.Label LoginPWLB;
        private System.Windows.Forms.Label LoginUserNameLB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox RegisterGB;
        private System.Windows.Forms.TextBox RegPWTB;
        private System.Windows.Forms.TextBox RegPWTB2;
        private System.Windows.Forms.TextBox RegEmailTB;
        private System.Windows.Forms.Label RegEmailLB;
        private System.Windows.Forms.Label RegPasswordLB2;
        private System.Windows.Forms.TextBox RegUNTB;
        private System.Windows.Forms.Button RegisterButton2;
        private System.Windows.Forms.Label RegisterErrorLB;
        private System.Windows.Forms.Label RegPasswordLB;
        private System.Windows.Forms.Label RegUserNameLB;
        private System.Windows.Forms.Button LoginBackButton;
        private System.Windows.Forms.Button RegisterBackButton;
    }
}

