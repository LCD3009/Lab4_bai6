namespace Lab4_Bai6
{
    partial class Login
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
            this.lb_tittle = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_passWord = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.LinkSignUp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lb_tittle
            // 
            this.lb_tittle.AutoSize = true;
            this.lb_tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tittle.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_tittle.Location = new System.Drawing.Point(85, 19);
            this.lb_tittle.Name = "lb_tittle";
            this.lb_tittle.Size = new System.Drawing.Size(250, 31);
            this.lb_tittle.TabIndex = 0;
            this.lb_tittle.Text = "HÔM NAY ĂN GÌ?";
            this.lb_tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(39, 76);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(70, 16);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "Username";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(41, 116);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(67, 16);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Don\'t have an account yet?";
            // 
            // txt_userName
            // 
            this.txt_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.Location = new System.Drawing.Point(132, 73);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(156, 22);
            this.txt_userName.TabIndex = 4;
            // 
            // txt_passWord
            // 
            this.txt_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passWord.Location = new System.Drawing.Point(132, 113);
            this.txt_passWord.Name = "txt_passWord";
            this.txt_passWord.PasswordChar = '*';
            this.txt_passWord.Size = new System.Drawing.Size(156, 22);
            this.txt_passWord.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(303, 73);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(79, 62);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // LinkSignUp
            // 
            this.LinkSignUp.AutoSize = true;
            this.LinkSignUp.Location = new System.Drawing.Point(302, 174);
            this.LinkSignUp.Name = "LinkSignUp";
            this.LinkSignUp.Size = new System.Drawing.Size(45, 13);
            this.LinkSignUp.TabIndex = 7;
            this.LinkSignUp.TabStop = true;
            this.LinkSignUp.Text = "Sign Up";
            this.LinkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSignUp_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 197);
            this.Controls.Add(this.LinkSignUp);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_passWord);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_tittle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Hôm nay ăn gì? - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tittle;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_passWord;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel LinkSignUp;
    }
}