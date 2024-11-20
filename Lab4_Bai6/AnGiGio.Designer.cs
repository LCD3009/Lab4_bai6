namespace Lab4_Bai6
{
    partial class AnGiGio
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
            this.flowLayoutPanelFood = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelFood
            // 
            this.flowLayoutPanelFood.Location = new System.Drawing.Point(13, 9);
            this.flowLayoutPanelFood.Name = "flowLayoutPanelFood";
            this.flowLayoutPanelFood.Size = new System.Drawing.Size(445, 140);
            this.flowLayoutPanelFood.TabIndex = 0;
            // 
            // AnGiGio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 161);
            this.Controls.Add(this.flowLayoutPanelFood);
            this.Name = "AnGiGio";
            this.Text = "Ăn gì giờ?";
            this.Load += new System.EventHandler(this.AnGiGio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFood;
    }
}