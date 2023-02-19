using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using callapi.Models;
using Newtonsoft.Json.Linq;

namespace callapi.service
{
    public class CallApi
    {
         
        

        public class BodyInfo
        {
            public string Nationalcode { get; set; }

        }

        public List<MyResponseModel> PostApI(BodyInfo body, string token)
        {


            List<MyResponseModel> _Result = null;
            var address = "https://gateway.dayins.com/v1/api/CarInquiry/InquiryPolicyByNationalCode";
            using (HttpClient Client = new HttpClient())
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                using (HttpRequestMessage bodyRequest = new HttpRequestMessage(HttpMethod.Post, address))
                {
                    bodyRequest.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
                    Task<HttpResponseMessage> responseApi = Client.PostAsync(address, bodyRequest.Content, new System.Threading.CancellationToken(false));
                    if (responseApi.Result.StatusCode == HttpStatusCode.OK)
                    {
                        if (responseApi.Result.IsSuccessStatusCode)
                        {
                            Task<string> finalRes = responseApi.Result.Content.ReadAsStringAsync();

                            JToken jobject = JObject.Parse(finalRes.Result);
                            string res = jobject["result"].ToString();
                            var _Result1 = JsonConvert.DeserializeObject<List<MyResponseModel>>(res).ToList();
                            return _Result1;
                        }
                    }
                    return null;
                }
            }
        }
    }
}
