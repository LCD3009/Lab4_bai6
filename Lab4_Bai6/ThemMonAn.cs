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
        public ThemMonAn()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện nhấn nút Clear để làm sạch các trường nhập liệu
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ten.Clear();
            txt_gia.Clear();
            txt_thongtin.Clear();
            txt_hinhanh.Clear();
            txt_diachi.Clear();
        }

        // Xử lý sự kiện nhấn nút Add để thêm món ăn
        private async void btn_add_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string tenMonAn = txt_ten.Text;
            decimal gia = 0;
            string moTa = txt_gia.Text;
            string hinhAnh = txt_thongtin.Text;
            string diaChi = txt_diachi.Text;

            // Kiểm tra tính hợp lệ của giá
            if (!decimal.TryParse(txt_gia.Text, out gia) || gia <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ.");
                return;
            }

            // Gọi phương thức thêm món ăn
            await AddFoodItemAsync("your_token_here", tenMonAn, gia, moTa, hinhAnh, diaChi);

            // Sau khi thêm món ăn, làm sạch các trường
            btn_Clear_Click(sender, e);  // Gọi lại phương thức Clear
        }

        // Phương thức gửi yêu cầu POST để thêm món ăn
        public async Task AddFoodItemAsync(string token, string tenMonAn, decimal gia, string moTa, string hinhAnh, string diaChi)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Dữ liệu món ăn cần thêm
                var foodItem = new
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
                    string json = JsonSerializer.Serialize(foodItem);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Gửi yêu cầu POST đến API để thêm món ăn
                    var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan", content);

                    // Kiểm tra nếu phản hồi thành công
                    if (response.IsSuccessStatusCode)
                    {
                        string responseJson = await response.Content.ReadAsStringAsync();

                        // Deserialize phản hồi thành đối tượng để lấy thông tin món ăn vừa được thêm
                        var apiResponse = JsonSerializer.Deserialize<ApiResponse>(responseJson);

                        if (apiResponse != null)
                        {
                            MessageBox.Show("Thêm món ăn thành công:\n" +
                                            $"Tên món ăn: {apiResponse.TenMonAn}\n" +
                                            $"Giá: {apiResponse.Gia}\n" +
                                            $"Mô tả: {apiResponse.MoTa}\n" +
                                            $"Địa chỉ: {apiResponse.DiaChi}\n" +
                                            $"Người đóng góp: {apiResponse.NguoiDongGop}");
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

        // Lớp ApiResponse dùng để lưu trữ dữ liệu món ăn trả về từ API
        public class ApiResponse
        {
            public string Id { get; set; }
            public string TenMonAn { get; set; }
            public decimal Gia { get; set; }
            public string MoTa { get; set; }
            public string HinhAnh { get; set; }
            public string DiaChi { get; set; }
            public string NguoiDongGop { get; set; }
        }
    }
}
