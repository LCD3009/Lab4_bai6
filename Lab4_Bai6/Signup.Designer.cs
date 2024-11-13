namespace Lab4_Bai6
{
    partial class SignUp
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
            this.signUp_Box = new System.Windows.Forms.GroupBox();
            this.txt_passWord = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.lb_passWord = new System.Windows.Forms.Label();
            this.lb_userName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.lb_sex = new System.Windows.Forms.Label();
            this.lb_birthday = new System.Windows.Forms.Label();
            this.lb_language = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_lName = new System.Windows.Forms.Label();
            this.lb_fName = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.txt_lName = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.signUp_Box.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_tittle
            // 
            this.lb_tittle.AutoSize = true;
            this.lb_tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tittle.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_tittle.Location = new System.Drawing.Point(82, 9);
            this.lb_tittle.Name = "lb_tittle";
            this.lb_tittle.Size = new System.Drawing.Size(250, 31);
            this.lb_tittle.TabIndex = 1;
            this.lb_tittle.Text = "HÔM NAY ĂN GÌ?";
            this.lb_tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUp_Box
            // 
            this.signUp_Box.Controls.Add(this.txt_passWord);
            this.signUp_Box.Controls.Add(this.txt_userName);
            this.signUp_Box.Controls.Add(this.lb_passWord);
            this.signUp_Box.Controls.Add(this.lb_userName);
            this.signUp_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_Box.Location = new System.Drawing.Point(12, 55);
            this.signUp_Box.Name = "signUp_Box";
            this.signUp_Box.Size = new System.Drawing.Size(390, 111);
            this.signUp_Box.TabIndex = 2;
            this.signUp_Box.TabStop = false;
            this.signUp_Box.Text = "Sign Up";
            // 
            // txt_passWord
            // 
            this.txt_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passWord.Location = new System.Drawing.Point(123, 64);
            this.txt_passWord.Name = "txt_passWord";
            this.txt_passWord.Size = new System.Drawing.Size(253, 23);
            this.txt_passWord.TabIndex = 10;
            // 
            // txt_userName
            // 
            this.txt_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.Location = new System.Drawing.Point(123, 30);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(253, 23);
            this.txt_userName.TabIndex = 9;
            // 
            // lb_passWord
            // 
            this.lb_passWord.AutoSize = true;
            this.lb_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_passWord.Location = new System.Drawing.Point(15, 67);
            this.lb_passWord.Name = "lb_passWord";
            this.lb_passWord.Size = new System.Drawing.Size(69, 17);
            this.lb_passWord.TabIndex = 8;
            this.lb_passWord.Text = "Password";
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.Location = new System.Drawing.Point(15, 33);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(73, 17);
            this.lb_userName.TabIndex = 7;
            this.lb_userName.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_language);
            this.groupBox2.Controls.Add(this.rb_female);
            this.groupBox2.Controls.Add(this.rb_male);
            this.groupBox2.Controls.Add(this.dtp_birthday);
            this.groupBox2.Controls.Add(this.lb_sex);
            this.groupBox2.Controls.Add(this.lb_birthday);
            this.groupBox2.Controls.Add(this.lb_language);
            this.groupBox2.Controls.Add(this.lb_phone);
            this.groupBox2.Controls.Add(this.lb_lName);
            this.groupBox2.Controls.Add(this.lb_fName);
            this.groupBox2.Controls.Add(this.lb_email);
            this.groupBox2.Controls.Add(this.txt_phone);
            this.groupBox2.Controls.Add(this.txt_fName);
            this.groupBox2.Controls.Add(this.txt_lName);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 314);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Infomation";
            // 
            // cb_language
            // 
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Items.AddRange(new object[] {
            "EN",
            "VI"});
            this.cb_language.Location = new System.Drawing.Point(123, 232);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(253, 24);
            this.cb_language.TabIndex = 14;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(269, 271);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(72, 21);
            this.rb_female.TabIndex = 13;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(123, 271);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(56, 21);
            this.rb_male.TabIndex = 12;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(123, 185);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(253, 23);
            this.dtp_birthday.TabIndex = 10;
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(15, 273);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(31, 17);
            this.lb_sex.TabIndex = 4;
            this.lb_sex.Text = "Sex";
            // 
            // lb_birthday
            // 
            this.lb_birthday.AutoSize = true;
            this.lb_birthday.Location = new System.Drawing.Point(15, 191);
            this.lb_birthday.Name = "lb_birthday";
            this.lb_birthday.Size = new System.Drawing.Size(60, 17);
            this.lb_birthday.TabIndex = 9;
            this.lb_birthday.Text = "Birthday";
            // 
            // lb_language
            // 
            this.lb_language.AutoSize = true;
            this.lb_language.Location = new System.Drawing.Point(15, 232);
            this.lb_language.Name = "lb_language";
            this.lb_language.Size = new System.Drawing.Size(72, 17);
            this.lb_language.TabIndex = 8;
            this.lb_language.Text = "Language";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(15, 150);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(49, 17);
            this.lb_phone.TabIndex = 7;
            this.lb_phone.Text = "Phone";
            // 
            // lb_lName
            // 
            this.lb_lName.AutoSize = true;
            this.lb_lName.Location = new System.Drawing.Point(15, 109);
            this.lb_lName.Name = "lb_lName";
            this.lb_lName.Size = new System.Drawing.Size(70, 17);
            this.lb_lName.TabIndex = 6;
            this.lb_lName.Text = "Lastname";
            // 
            // lb_fName
            // 
            this.lb_fName.AutoSize = true;
            this.lb_fName.Location = new System.Drawing.Point(15, 68);
            this.lb_fName.Name = "lb_fName";
            this.lb_fName.Size = new System.Drawing.Size(70, 17);
            this.lb_fName.TabIndex = 5;
            this.lb_fName.Text = "Firstname";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(15, 27);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(42, 17);
            this.lb_email.TabIndex = 4;
            this.lb_email.Text = "Email";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(123, 147);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(253, 23);
            this.txt_phone.TabIndex = 3;
            // 
            // txt_fName
            // 
            this.txt_fName.Location = new System.Drawing.Point(123, 65);
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(253, 23);
            this.txt_fName.TabIndex = 2;
            // 
            // txt_lName
            // 
            this.txt_lName.Location = new System.Drawing.Point(123, 106);
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(253, 23);
            this.txt_lName.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(123, 24);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(253, 23);
            this.txt_email.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(204, 492);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 34);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.White;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(306, 492);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(96, 34);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 528);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.signUp_Box);
            this.Controls.Add(this.lb_tittle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.Text = "Hôm nay ăn gì? - Signup";
            this.signUp_Box.ResumeLayout(false);
            this.signUp_Box.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tittle;
        private System.Windows.Forms.GroupBox signUp_Box;
        private System.Windows.Forms.TextBox txt_passWord;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label lb_passWord;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_birthday;
        private System.Windows.Forms.Label lb_language;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_lName;
        private System.Windows.Forms.Label lb_fName;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.TextBox txt_lName;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.ComboBox cb_language;
    }
}