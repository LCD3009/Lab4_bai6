using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using static Lab4_Bai6.MainForm;

namespace Lab4_Bai6
{
    public partial class MainForm : Form
    {
        // Lớp đại diện cho thông tin người dùng
        public class UserInfo
        {
            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }
        }

        // Lớp đại diện cho thông tin phân trang
        public class Pagination
        {
            [JsonPropertyName("current")]
            public int CurrentPage { get; set; }

            [JsonPropertyName("pageSize")]
            public int PageSize { get; set; }

            [JsonPropertyName("total")]
            public int TotalItems { get; set; }
        }

        // Lớp đại diện cho một món ăn
        public class FoodItem
        {
            [JsonPropertyName("id")]
            [JsonConverter(typeof(IdToStringConverter))]  // Áp dụng converter để chuyển `id` thành chuỗi
            public string Id { get; set; }

            [JsonPropertyName("ten_mon_an")]
            public string Name { get; set; }

            [JsonPropertyName("gia")]
            public decimal Price { get; set; }

            [JsonPropertyName("mo_ta")]
            public string Description { get; set; }

            [JsonPropertyName("hinh_anh")]
            public string Image { get; set; }

            [JsonPropertyName("dia_chi")]
            public string Address { get; set; }

            [JsonPropertyName("nguoi_dong_gop")]
            public string Contributor { get; set; }
        }

        // Lớp đại diện cho phản hồi từ API
        public class ApiResponse
        {
            [JsonPropertyName("data")]
            public List<FoodItem> Data { get; set; }

            [JsonPropertyName("pagination")]
            public Pagination Pagination { get; set; }

            [JsonPropertyName("msg")]  // Trường msg trong phản hồi lỗi (nếu có)
            public string Message { get; set; }
        }

        // Lớp đại diện cho món ăn gửi lên API (POST)
        public class FoodItemToPost
        {
            [JsonPropertyName("ten_mon_an")]
            public string Name { get; set; }

            [JsonPropertyName("gia")]
            public decimal Price { get; set; }

            [JsonPropertyName("mo_ta")]
            public string Description { get; set; }

            [JsonPropertyName("dia_chi")]
            public string Address { get; set; }

            [JsonPropertyName("nguoi_dong_gop")]
            public string Contributor { get; set; }
        }

        // Converter để đảm bảo id luôn được chuyển thành chuỗi
        public class IdToStringConverter : JsonConverter<string>
        {
            public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.Null)
                {
                    return string.Empty;  // Trả về chuỗi rỗng nếu null
                }

                if (reader.TokenType == JsonTokenType.Number)
                {
                    return reader.GetInt64().ToString(); // Chuyển số thành chuỗi
                }

                return reader.GetString();  // Nếu giá trị là chuỗi, trả về chuỗi gốc
            }

            public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value);
            }
        }

        private string _accessToken;

        // Constructor nhận token từ Login
        public MainForm(string accessToken)
        {
            InitializeComponent();
            _accessToken = accessToken;
            flowLayoutPanelFood.AutoScroll = true;
        }

        // Hàm tải thông tin người dùng khi form được mở
        private async void MainForm_Load(object sender, EventArgs e)
        {
            var userInfo = await GetUserInfoAsync(_accessToken);

            if (userInfo != null)
            {
                MessageBox.Show($"User: {userInfo.Username}, Email: {userInfo.Email}");
            }
            else
            {
                MessageBox.Show("Failed to retrieve user information.");
            }

            // Gọi hàm lấy món ăn với phân trang
            await PostFoodItemsWithPaginationAsync(_accessToken);
        }

        // Hàm lấy thông tin người dùng từ API
        private async Task<UserInfo> GetUserInfoAsync(string token)
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

        // Hàm gửi yêu cầu POST lên API với dữ liệu phân trang
        private async Task PostFoodItemsWithPaginationAsync(string token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                // Tạo đối tượng chứa dữ liệu phân trang
                var paginationData = new
                {
                    current = 1,
                    pageSize = 5
                };

                try
                {
                    // Serialize dữ liệu phân trang thành JSON
                    string json = JsonSerializer.Serialize(paginationData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Gửi yêu cầu POST đến API
                    var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/all", content);

                    // Kiểm tra trạng thái phản hồi từ API
                    if (response.IsSuccessStatusCode)
                    {
                        string responseJson = await response.Content.ReadAsStringAsync();
                        // Deserialize phản hồi thành đối tượng ApiResponse
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };
                        var apiResponse = JsonSerializer.Deserialize<ApiResponse>(responseJson, options);

                        // Kiểm tra nếu có dữ liệu món ăn và phân trang
                        if (apiResponse != null && apiResponse.Data != null && apiResponse.Data.Count > 0)
                        {
                            // Xóa tất cả các control cũ trong FlowLayoutPanel
                            flowLayoutPanelFood.Controls.Clear();

                            // Cấu hình FlowLayoutPanel để các item xếp theo chiều dọc (mỗi món ăn là một dòng)
                            flowLayoutPanelFood.FlowDirection = FlowDirection.TopDown; // Xếp theo chiều dọc
                            flowLayoutPanelFood.WrapContents = false; // Không cho phép các panel tự động xuống dòng khi hết không gian

                            foreach (var foodItem in apiResponse.Data)
                            {
                                // Tạo một Panel mới cho món ăn
                                var foodPanel = new Panel
                                {
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Size = new System.Drawing.Size(400, 200), // Điều chỉnh kích thước Panel cho phù hợp
                                    Padding = new Padding(10),
                                    Margin = new Padding(0, 5, 0, 5) // Thêm khoảng cách giữa các panel
                                };

                                // Tạo và thêm tên món ăn
                                var lblName = new Label
                                {
                                    Text = $"Tên món ăn: {foodItem.Name}",
                                    Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold),
                                    AutoSize = true
                                };
                                foodPanel.Controls.Add(lblName);

                                // Tạo và thêm giá món ăn
                                var lblPrice = new Label
                                {
                                    Text = $"Giá: {foodItem.Price:C}",
                                    AutoSize = true
                                };
                                foodPanel.Controls.Add(lblPrice);

                                // Tạo và thêm mô tả món ăn
                                var lblDescription = new Label
                                {
                                    Text = $"Mô tả: {foodItem.Description}",
                                    AutoSize = true
                                };
                                foodPanel.Controls.Add(lblDescription);

                                // Tạo và thêm địa chỉ
                                var lblAddress = new Label
                                {
                                    Text = $"Địa chỉ: {foodItem.Address}",
                                    AutoSize = true
                                };
                                foodPanel.Controls.Add(lblAddress);

                                // Tạo và thêm người đóng góp
                                var lblContributor = new Label
                                {
                                    Text = $"Người đóng góp: {foodItem.Contributor}",
                                    AutoSize = true
                                };
                                foodPanel.Controls.Add(lblContributor);

                                // Thêm Panel này vào FlowLayoutPanel
                                flowLayoutPanelFood.Controls.Add(foodPanel);
                            }

                            // Hiển thị thông tin phân trang
                            MessageBox.Show($"Tổng số món ăn: {apiResponse.Pagination.TotalItems}");
                        }
                        else
                        {
                            MessageBox.Show("Không có món ăn nào.");
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


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ThemMonAn them = new ThemMonAn();
            them.Show();
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
        }

    }
}

