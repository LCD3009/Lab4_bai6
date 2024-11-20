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
            int sex = rb_male.Checked ? 0 : 1;
            DateTime birthday = dtp_birthday.Value;
            string language = cb_language.Text;
            string phone = txt_phone.Text;

            var userData = new UserData(username, email, password, firstName, lastName, sex, birthday, language, phone);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            var result = await RegisterAccount(userData);

            if (result.IsSuccess)
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi đăng ký: " + result.ErrorMessage);
            }
        }

        private async Task<(bool IsSuccess, string ErrorMessage)> RegisterAccount(UserData userInfo)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var userData = userInfo;

                string jsonContent = JsonSerializer.Serialize(userData);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync("https://nt106.uitiot.vn/api/v1/user/signup", content);

                    if (response.IsSuccessStatusCode)
                    {
                        return (true, null);
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Phản hồi lỗi: {errorResponse}"); // In ra nội dung phản hồi lỗi

                        string errorMessage = "Đăng ký thất bại"; // Thông báo lỗi mặc định

                        try
                        {
                            var errorData = JsonSerializer.Deserialize<ErrorResponse>(errorResponse);
                            errorMessage = errorData?.Detail ?? errorMessage;
                        }
                        catch (JsonException)
                        {
                            errorMessage = "Không thể phân tích lỗi từ máy chủ.";
                        }

                        return (false, errorMessage);
                    }
                }
                catch (Exception ex)
                {
                    return (false, "Lỗi kết nối: " + ex.Message);
                }
            }
        }

        public class ErrorResponse
        {
            [JsonPropertyName("detail")]
            public string Detail { get; set; }
        }
    }
}
