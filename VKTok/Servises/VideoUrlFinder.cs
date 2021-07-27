using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VKTok.Servises
{
    static class VideoUrlFinder
    {
        public static async Task<string> GetURLAsync(int userId, int VideoId, string AccsesCode)
        {
            await Task.Delay(1000);
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://api.vk.com/method/" +
                $"video.get?" +
                $"&access_token={SingletonManeger.AuthKeys["access_token"]}" +
                $"&videos={userId}_{VideoId}_{AccsesCode}" +
                $"&v=5.131");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var root = JObject.Parse(responseBody);
            return root["response"]["items"][0]["player"].ToString();
        }
    }
}
