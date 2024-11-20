using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Lab4_Bai6
{
    // Login
    public class UserInfo
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
    public class TokenResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
    }

    // Sign up
    // ---------- Request
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

    // Main form
    //---------- Responses
    public class ApiResponse
    {
        [JsonPropertyName("data")]
        public List<FoodItem> Data { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("msg")]  // Trường msg trong phản hồi lỗi (nếu có)
        public string Message { get; set; }
    }

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
    public class Pagination
    {
        [JsonPropertyName("current")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("total")]
        public int TotalItems { get; set; }
    }


    // Them mon an
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
    
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
