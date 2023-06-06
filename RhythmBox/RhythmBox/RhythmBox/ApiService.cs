using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RhythmBox
{
    internal class ApiService
    {
        private readonly HttpClient httpClient;
        private const string BaseUrl = "https://example.com/api";

        public ApiService()
        {
            httpClient = new HttpClient();
        }

        public async Task<bool> SignIn(string username, string password)
        {
            var user = new UserSignInDataClass(username, password);
            var userJson = JsonConvert.SerializeObject(user);

            var content = new StringContent(userJson, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"{BaseUrl}/login", content);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                TokenManager.SetAccessToken(responseJson);
                return true;
            }
            return false;
        }

        public async Task<bool> SignUp(string username, string email, string password, DateTime birthday, string gender)
        {
            var user = new UserSignUpDataClass(username, email, password, birthday, gender);
            var userJson = JsonConvert.SerializeObject(user);

            var content = new StringContent(userJson, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"{BaseUrl}/register", content);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> ForgotPassword(string email)
        {
            var request = new
            {
                email = email
            };
            var requestJson = JsonConvert.SerializeObject(request);

            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"{BaseUrl}/forgotpassword", content);

            if (!response.IsSuccessStatusCode)
                return false;
            return true;
        }

        public async Task<bool> AuthOTP(string email, int enteredOtp)
        {
            try
            {
                var otpRequest = new
                {
                    email = email,
                    otp = enteredOtp
                };

                var otpRequestJson = JsonConvert.SerializeObject(otpRequest);

                var content = new StringContent(otpRequestJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync($"{BaseUrl}/Authentication", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> RenewPassword(string email, string newpass)
        {
            var request = new
            {
                email = email,
                newpass = newpass

            };
            var requestJson = JsonConvert.SerializeObject(request);

            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"{BaseUrl}/RenewPassword", content);

            if (!response.IsSuccessStatusCode)
                return false;
            return true;
        }
    }
}
