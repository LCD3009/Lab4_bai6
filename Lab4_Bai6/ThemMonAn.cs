using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai6
{
    public partial class ThemMonAn : Form
    {
        private string _accessToken;

        public ThemMonAn(string accessToken)
        {
            InitializeComponent();
            _accessToken = accessToken;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ten.Clear();
            txt_gia.Clear();
            txt_thongtin.Clear();
            txt_hinhanh.Clear();
            txt_diachi.Clear();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            string tenMonAn = txt_ten.Text;
            decimal gia = 0;
            string moTa = txt_gia.Text;
            string hinhAnh = txt_thongtin.Text;
            string diaChi = txt_diachi.Text;

            if (!decimal.TryParse(txt_gia.Text, out gia) || gia <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ.");
                return;
            }

            await AddFoodItemAsync(_accessToken, tenMonAn, gia, moTa, hinhAnh, diaChi);

            btn_Clear_Click(sender, e);
        }

        // Phương thức gửi yêu cầu POST để thêm món ăn
        public async Task AddFoodItemAsync(string token, string tenMonAn, decimal gia, string moTa, string hinhAnh, string diaChi)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Dữ liệu món ăn cần thêm
                var food = new
                {
                    ten_mon_an = tenMonAn,
                    gia = gia,
                    mo_ta = moTa,
                    hinh_anh = hinhAnh,
                    dia_chi = diaChi
                };

                try
                {
                    // Serialize đối tượng thành chuỗi JSON
                    string json = JsonSerializer.Serialize(food);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Gửi yêu cầu POST đến API để thêm món ăn
                    var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/add", content);

                    // Kiểm tra nếu phản hồi thành công
                    if (response.IsSuccessStatusCode)
                    {
                        string responseJson = await response.Content.ReadAsStringAsync();

                        var apiResponse = JsonSerializer.Deserialize<ApiResponse>(responseJson);

                        if (apiResponse != null)
                        {
                            MessageBox.Show("Thêm món ăn thành công");
                        }
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Lỗi khi thêm món ăn: {errorMessage}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }
    }
}
