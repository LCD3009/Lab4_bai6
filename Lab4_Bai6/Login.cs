﻿using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_userName.Text;
            string password = txt_passWord.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var tokenData = await LoginAsync(username, password);

            if (tokenData != null)
            {
                var userInfo = await GetUserInfoAsync(tokenData.AccessToken);

                if (userInfo != null)
                {
                    // Truyền token vào MainForm
                    MainForm mainForm = new MainForm(tokenData.AccessToken);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to retrieve user information.");
                }
            }
            else
            {
                MessageBox.Show("Invalid login credentials!");
            }
        }


        private async Task<TokenResponse> LoginAsync(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                var formData = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };

                try
                {
                    var response = await client.PostAsync("https://nt106.uitiot.vn/auth/token", formData);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseJson = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };
                        return JsonSerializer.Deserialize<TokenResponse>(responseJson, options);
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Login error: {errorMessage}");
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

        public class TokenResponse
        {
            [JsonPropertyName("access_token")]
            public string AccessToken { get; set; }

            [JsonPropertyName("token_type")]
            public string TokenType { get; set; }
        }

        public class UserInfo
        {
            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            // Add more properties if needed
        }

        private void LinkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}