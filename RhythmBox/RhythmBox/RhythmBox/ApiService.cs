using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http;
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

            var response = await httpClient.PostAsync($"{BaseUrl}/signin", content);

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

            var response = await httpClient.PostAsync($"{BaseUrl}/signup", content);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                return true;
            }

            return false;
        }
    }
}
