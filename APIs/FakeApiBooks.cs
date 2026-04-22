using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace APIs
{
    internal class FakeApiBooks
    {
        private static readonly string BASE_URL = "https://fakerapi.it/api/v2";

        public static async Task<Response?> GetBookAsync(int quantity)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                
                string url = $"{BASE_URL}/Books?_quantity={quantity}";

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (!string.IsNullOrEmpty(responseBody))
                    {
                        return JsonSerializer.Deserialize<Response>(responseBody);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("Our exception: " + ex);
                    return null;
                }
            }
        }
    }
}
