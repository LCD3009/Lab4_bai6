using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai6
{
    public partial class AnGiGio : Form
    {
        private FoodItem _food;
        public AnGiGio(FoodItem food)
        {
            InitializeComponent();
            _food = food;
        }

        private void AnGiGio_Load(object sender, EventArgs e)
        {
            var foodPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new System.Drawing.Size(510, 150), // Điều chỉnh kích thước Panel cho phù hợp
                Padding = new Padding(10),
                Margin = new Padding(0, 5, 0, 5), // Thêm khoảng cách giữa các panel
            };
            var pictureBox = new PictureBox
            {
                Size = new System.Drawing.Size(140, 140),
                Location = new System.Drawing.Point(5, 5),
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = _food.Image,
                BorderStyle = BorderStyle.FixedSingle,
            };

            foodPanel.Controls.Add(pictureBox);

            var lblName = new Label
            {
                Text = _food.Name,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("Arial", 13, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 10),
                Location = new System.Drawing.Point(160, 10),
            };
            foodPanel.Controls.Add(lblName);
            var lblPrice = new Label
            {
                Text = $"Giá:",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("Arial", 10),
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 5),
                Location = new System.Drawing.Point(160, 40),
            };
            foodPanel.Controls.Add(lblPrice);
            var lblAddress = new Label
            {
                Text = "Địa chỉ:",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("Arial", 10),
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 5),
                Location = new System.Drawing.Point(160, 70),
            };
            foodPanel.Controls.Add(lblAddress);
            var lblContributor = new Label
            {
                Text = "Đóng góp:",
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("Arial", 10),
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 5),
                Location = new System.Drawing.Point(160, 100),
            };
            foodPanel.Controls.Add(lblContributor);

            var lblPriceValue = new Label
            {
                Text = Convert.ToInt32(_food.Price).ToString(),
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("Arial", 10),
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 5),
                Location = new System.Drawing.Point(230, 40),
            };
            foodPanel.Controls.Add(lblPriceValue);
            var lblAddressValue = new Label
            {
                Text = _food.Address,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("Arial", 10),
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 5),
                Location = new System.Drawing.Point(230, 70),
            };
            foodPanel.Controls.Add(lblAddressValue);
            var lblContributorValue = new Label
            {
                Text = _food.Contributor,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("Arial", 10),
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 5),
                Location = new System.Drawing.Point(230, 100),
            };

            foodPanel.Controls.Add(lblContributorValue);
            flowLayoutPanelFood.Controls.Add(foodPanel);
        }
    }
}
