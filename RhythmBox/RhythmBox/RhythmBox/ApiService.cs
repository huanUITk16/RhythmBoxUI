using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RhythmBox
{
    internal class ApiService
    {
        private readonly HttpClient httpClient;
        private const string BaseUrl = "https://rhythmboxserver.azurewebsites.net/api";

        public ApiService()
        {
            httpClient = new HttpClient();
        }

        public async Task<bool> SignIn(string username, string password)
        {
            var user = new UserSignInDataClass(username, password);
            var userJson = JsonConvert.SerializeObject(user);

            var content = new StringContent(userJson, Encoding.UTF8, "application/json");

            string requestUrl = $"{BaseUrl}/Account/login?email={username}&password={password}";

            var response = await httpClient.PostAsync(requestUrl, null);

            var responseJson = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
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

            string requestUrl = $"{BaseUrl}/Account/register?userName={username}&email={email}&password={password}&birthday={birthday}&gender={gender}";

            var response = await httpClient.PostAsync(requestUrl, null);
            var responseJson = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
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

            string requestUrl = $"{BaseUrl}/Forgotpassword?email={email}";

            var response = await httpClient.PostAsync(requestUrl, null);

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

                string requestUrl = $"{BaseUrl}/ForgotPassword/Authentication?email={email}&enteredOtp={enteredOtp}";

                var response = await httpClient.PostAsync(requestUrl, null);

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

            string requestUrl = $"{BaseUrl}/Forgotpassword/RenewPassword?email={email}&newPassword={newpass}";

            var response = await httpClient.PostAsync(requestUrl, null);

            if (!response.IsSuccessStatusCode)
                return false;
            return true;
        }
    }
}
