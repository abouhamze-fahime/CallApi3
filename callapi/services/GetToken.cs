using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace mvcCrud.service
{
    public class GetToken
    {
        public class LoginModel
        {
            [Required]
            public string UserName { get; set; }
            [Required]
            public string Password { get; set; }
        }

        public class Content
        {
            public string content;

        }
        public string GetToken2(LoginModel user)
        {
            string baseAddress = "https://gateway.dayins.com/v1/api/token";
            using (HttpClient Client = new HttpClient())
            {
                using (HttpRequestMessage bodyRequest = new HttpRequestMessage(HttpMethod.Post, baseAddress))
                {
                    bodyRequest.Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                    HttpResponseMessage responseApi = Client.PostAsync(baseAddress, bodyRequest.Content, new System.Threading.CancellationToken(false)).Result;

                    if (responseApi.IsSuccessStatusCode)
                    {
                        var finalRes = responseApi.Content.ReadAsStringAsync().Result;
                        var _Result = finalRes;

                        if (_Result != null)
                        {
                            JToken jobject = JObject.Parse(_Result);
                            Content c = new Content()
                            {
                                content = (jobject["result"]["content"].ToString())
                            };

                            //JObject dataa = JObject.Parse(_Result);
                            //JObject dataa2 = JObject.Parse(_Result);
                            //JToken res = dataa.SelectToken("result");
                            //ResponseText = res.ToString();
                            return c.content;
                        }
                        else
                        {
                            return "Response is null";
                        };
                    }
                    // }
                    else
                    {
                        return "There is Error";
                    }
                }
            }

        }
    }
}
