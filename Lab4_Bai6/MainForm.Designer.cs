namespace Lab4_Bai6
{
    partial class MainForm
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
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_tittle = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelFood = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_random
            // 
            this.btn_random.BackColor = System.Drawing.Color.White;
            this.btn_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_random.Location = new System.Drawing.Point(313, 38);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(110, 44);
            this.btn_random.TabIndex = 1;
            this.btn_random.Text = "ĂN GÌ GIỜ";
            this.btn_random.UseVisualStyleBackColor = false;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(429, 38);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 44);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "THÊM MÓN ĂN";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_tittle
            // 
            this.lb_tittle.AutoSize = true;
            this.lb_tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tittle.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_tittle.Location = new System.Drawing.Point(12, 22);
            this.lb_tittle.Name = "lb_tittle";
            this.lb_tittle.Size = new System.Drawing.Size(250, 31);
            this.lb_tittle.TabIndex = 4;
            this.lb_tittle.Text = "HÔM NAY ĂN GÌ?";
            this.lb_tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(89, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(448, 407);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(503, 407);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(49, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "5";
            // 
            // flowLayoutPanelFood
            // 
            this.flowLayoutPanelFood.Location = new System.Drawing.Point(18, 105);
            this.flowLayoutPanelFood.Name = "flowLayoutPanelFood";
            this.flowLayoutPanelFood.Size = new System.Drawing.Size(521, 283);
            this.flowLayoutPanelFood.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.flowLayoutPanelFood);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lb_tittle);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_random);
            this.Name = "MainForm";
            this.Text = "Hôm nay ăn gì?";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_tittle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFood;
    }
}

