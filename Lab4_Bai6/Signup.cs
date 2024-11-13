using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai6
{
    public partial class SignUp : Form
    {
        public class UserData
        {
            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("password")]
            public string Password { get; set; }

            [JsonPropertyName("first_name")]
            public string FirstName { get; set; }

            [JsonPropertyName("last_name")]
            public string LastName { get; set; }

            [JsonPropertyName("sex")]
            public int Sex { get; set; }

            [JsonPropertyName("birthday")]
            public string Birthday { get; set; }

            [JsonPropertyName("language")]
            public string Language { get; set; }

            [JsonPropertyName("phone")]
            public string Phone { get; set; }

            public UserData(string username, string email, string password, string firstName, string lastName,
                            int sex, DateTime birthday, string language, string phone)
            {
                Username = username;
                Email = email;
                Password = password;
                FirstName = firstName;
                LastName = lastName;
                Sex = sex;
                Birthday = birthday.ToString("yyyy-MM-dd");
                Language = language;
                Phone = phone;
            }
        }


        public SignUp()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi người dùng nhấn nút đăng ký
        private async void btn_submit_Click(object sender, EventArgs e)
        {
            string username = txt_userName.Text;
            string email = txt_email.Text;
            string password = txt_passWord.Text;
            string firstName = txt_fName.Text;
            string lastName = txt_lName.Text;
            int sex = rb_male.Checked ? 0 : 1; // Giả sử 0 là Nam, 1 là Nữ
            DateTime birthday = dtp_birthday.Value;
            string language = cb_language.Text;
            string phone = txt_phone.Text;

            // Kiểm tra nếu các trường không hợp lệ
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            var result = await RegisterAccount(username, email, password, firstName, lastName, sex, birthday, language, phone);

            if (result.IsSuccess)
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close(); // Đóng form đăng ký sau khi đăng ký thành công
            }
            else
            {
                MessageBox.Show("Lỗi đăng ký: " + result.ErrorMessage);
            }
        }
        private async Task<(bool IsSuccess, string ErrorMessage)> RegisterAccount(string username,
                                                                 string email,
                                                                 string password,
                                                                 string firstName,
                                                                 string lastName,
                                                                 int sex,
                                                                 DateTime birthday,
                                                                 string language,
                                                                 string phone)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                // Tạo một đối tượng UserData
                var userData = new UserData(username, email, password, firstName, lastName, sex, birthday, language, phone);

                // Chuyển đổi UserData thành JSON
                string jsonContent = JsonSerializer.Serialize(userData);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                try
                {
                    // Gửi yêu cầu POST đến endpoint đăng ký
                    var response = await httpClient.PostAsync("https://nt106.uitiot.vn/api/v1/user/signup", content);

                    // Kiểm tra mã trạng thái HTTP của phản hồi
                    if (response.IsSuccessStatusCode)
                    {
                        return (true, null);
                    }
                    else
                    {
                        // Đọc phản hồi lỗi dưới dạng văn bản thuần túy
                        var errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Phản hồi lỗi: {errorResponse}"); // In ra nội dung phản hồi lỗi

                        // Thử giải mã phản hồi nếu đó là JSON
                        string errorMessage = "Đăng ký thất bại"; // Thông báo lỗi mặc định

                        try
                        {
                            var errorData = JsonSerializer.Deserialize<ErrorResponse>(errorResponse);
                            errorMessage = errorData?.Detail ?? errorMessage;
                        }
                        catch (JsonException)
                        {
                            // Nếu không thể giải mã JSON, thông báo lỗi chung
                            errorMessage = "Không thể phân tích lỗi từ máy chủ.";
                        }

                        // Trả về kết quả không thành công và thông báo lỗi
                        return (false, errorMessage);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi kết nối mạng hoặc các lỗi khác
                    return (false, "Lỗi kết nối: " + ex.Message);
                }
            }
        }


        // Lớp đại diện cho phản hồi lỗi
        public class ErrorResponse
        {
            [JsonPropertyName("detail")]
            public string Detail { get; set; }
        }
    }
}
