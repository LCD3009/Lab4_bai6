using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace Lab4_Bai6
{

    public partial class MainForm : Form
    {
        private string _accessToken;
        public List<FoodItem> allFoodItems = new List<FoodItem>();
        public List<FoodItem> allMyFoodItems = new List<FoodItem>();

        public MainForm(string accessToken)
        {
            InitializeComponent();
            _accessToken = accessToken;
            flowLayoutPanelFood.AutoScroll = true;
            flowLayoutPanelMyFood.AutoScroll = true ;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var userInfo = await GetUserInfo(_accessToken);

            info.Text = $"Welcome, {userInfo.Username}";

            await PostAllFood(_accessToken);

            await PostMyFood(_accessToken);

            DisplayFood(allFoodItems, flowLayoutPanelFood);
            DisplayFood(allMyFoodItems, flowLayoutPanelMyFood);
        }

        private async Task PostAllFood(string token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var paginationData = new
                {
                    current = 1,
                    pageSize = 5
                };

                try
                {
                    string json = JsonSerializer.Serialize(paginationData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/all", content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseJson = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };
                        var apiResponse = JsonSerializer.Deserialize<ApiResponse>(responseJson, options);

                        if (apiResponse != null && apiResponse.Data != null && apiResponse.Data.Count > 0)
                        {
                           // MessageBox.Show($"{apiResponse.Data.Count}");
                            allFoodItems = apiResponse.Data;
                        }
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error fetching food items: {errorMessage}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                }
            }
        }

        private async Task PostMyFood(string token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var paginationData = new
                {
                    current = 1,
                    pageSize = 5
                };

                try
                {
                    string json = JsonSerializer.Serialize(paginationData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/my-dishes", content);
                    
                    if (response.IsSuccessStatusCode)
                    {
                        string responseJson = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };
                        var apiResponse = JsonSerializer.Deserialize<ApiResponse>(responseJson, options);

                        if (apiResponse != null && apiResponse.Data != null && apiResponse.Data.Count > 0)
                        {
                            allMyFoodItems = apiResponse.Data;
                        }
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error fetching food items: {errorMessage}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                }
            }
        }

        private async Task<UserInfo> GetUserInfo(string token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                try
                {
                    var response = await client.GetAsync("https://nt106.uitiot.vn/api/v1/user/me");

                    if (response.IsSuccessStatusCode)
                    {
                        var responseJson = await response.Content.ReadAsStringAsync();

                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };
                        return JsonSerializer.Deserialize<UserInfo>(responseJson, options);
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error fetching user info: {errorMessage}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                    return null;
                }
            }
        }

        private void DisplayFood(List<FoodItem> listFood, FlowLayoutPanel flp_food)
        {
            for (int i = 0; i < listFood.Count; i++)
            {
                var foodItem = allFoodItems[i];

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
                    ImageLocation = foodItem.Image,
                    BorderStyle = BorderStyle.FixedSingle,
                };

                foodPanel.Controls.Add(pictureBox);
                
                var lblName = new Label
                {
                    Text = foodItem.Name,
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
                    Text = Convert.ToInt32(foodItem.Price).ToString(),
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new System.Drawing.Font("Arial", 10),
                    AutoSize = true,
                    Margin = new Padding(0, 5, 0, 5),
                    Location = new System.Drawing.Point(230, 40),
                };
                foodPanel.Controls.Add(lblPriceValue);
                var lblAddressValue = new Label
                {
                    Text = foodItem.Address,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new System.Drawing.Font("Arial", 10),
                    AutoSize = true,
                    Margin = new Padding(0, 5, 0, 5),
                    Location = new System.Drawing.Point(230, 70),
                };
                foodPanel.Controls.Add(lblAddressValue);
                var lblContributorValue = new Label
                {
                    Text = foodItem.Contributor,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new System.Drawing.Font("Arial", 10),
                    AutoSize = true,
                    Margin = new Padding(0, 5, 0, 5),
                    Location = new System.Drawing.Point(230, 100),
                };

                foodPanel.Controls.Add(lblContributorValue);
                flp_food.Controls.Add(foodPanel);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ThemMonAn them = new ThemMonAn(_accessToken);
            them.Show();
     
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            if (allFoodItems == null || allFoodItems.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn hiện đang trống!");
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(allFoodItems.Count);
            FoodItem randomFood = allFoodItems[randomIndex];
            AnGiGio angi = new AnGiGio(randomFood);
            angi.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}

