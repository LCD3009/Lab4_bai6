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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelFood = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelMyFood = new System.Windows.Forms.FlowLayoutPanel();
            this.info = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(144, 411);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 309);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanelFood);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tất cả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelFood
            // 
            this.flowLayoutPanelFood.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelFood.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanelFood.Name = "flowLayoutPanelFood";
            this.flowLayoutPanelFood.Size = new System.Drawing.Size(530, 270);
            this.flowLayoutPanelFood.TabIndex = 0;
            this.flowLayoutPanelFood.WrapContents = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanelMyFood);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tôi đóng góp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMyFood
            // 
            this.flowLayoutPanelMyFood.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMyFood.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanelMyFood.Name = "flowLayoutPanelMyFood";
            this.flowLayoutPanelMyFood.Size = new System.Drawing.Size(530, 270);
            this.flowLayoutPanelMyFood.TabIndex = 1;
            this.flowLayoutPanelMyFood.WrapContents = false;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(15, 413);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(35, 13);
            this.info.TabIndex = 9;
            this.info.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.info);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lb_tittle);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_random);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hôm nay ăn gì?";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_tittle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFood;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMyFood;
    }
}

