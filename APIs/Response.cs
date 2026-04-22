using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIs
{
    public class Response
    {
        [JsonPropertyName("status")]
        public string Status { get; set; } = "OK";


        [JsonPropertyName("code")]
        public int? Code { get; set; } 

        [JsonPropertyName("data")]
        public List<Book>? Data { get; set; } 
    }

}
