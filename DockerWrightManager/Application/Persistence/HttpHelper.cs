using System;
using System.Net.Http;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DockerWrightManager.Models.Settings;
using Newtonsoft.Json;

namespace DockerWrightManager.Persistence
{
    public class HttpHelper 
    {
        private readonly HttpClient client;

        public HttpHelper(AppSetting appSetting)
        {
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.SslProtocols = SslProtocols.Tls12;
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            if (appSetting.InfrstructureEnvironment == InfrstructureEnvironment.Kubernetes)
            {
                try
                {
                    handler.ClientCertificates.Add(new X509Certificate2(AppSetting.KUBERNETES_CA));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while adding kubernetes CERT. " + ex.Message);
                }
            }
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {appSetting.BearerToken}");
        }
        public async Task<T> SendAsync<T>(string url)
        {
            var request = new HttpRequestMessage(new HttpMethod("GET"), url);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(responseBody);
            return result;
        }

        public async Task<string> SendAsync(string url)
        {
            var request = new HttpRequestMessage(new HttpMethod("GET"), url);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();

        }

        public async Task<T> SendPostAsync<T>(string url, object body)
        {
            string bodyStr = "";
            if (body.GetType() == typeof(string))
                bodyStr = body.ToString();
            else
                bodyStr = JsonConvert.SerializeObject(body);
            var bodyString = new StringContent(bodyStr, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, bodyString);
            if (!response.IsSuccessStatusCode)
            {
                EventLogger.LogEvent(EventSeverity.Error, $"Failed post: {response.StatusCode} {await response.Content?.ReadAsStringAsync()} REQUEST: {bodyStr}");
            }
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(responseBody);
            return result;
        }

        public async Task<T> SendDeleteAsync<T>(string url)
        {
            var response = await client.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(responseBody);
            return result;
        }

        public async Task<T> SendDeleteAsync<T>(string url, object body)
        {
            string bodyStr = JsonConvert.SerializeObject(body);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url),
                Content = new StringContent(bodyStr, Encoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request);
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(responseBody);
            return result;
        }

        public async Task<T> SendPostAsync<T>(HttpRequestMessage request)
        {
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(responseBody);
            return result;
        }

        public async Task<string> SendPostRawAsync(HttpRequestMessage request)
        {
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public async Task<string> SendRawPostAsync(string url, object body)
        {
            var bodyString = new StringContent(FormatBody(body), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, bodyString);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public async Task<string> SendHtmlAsync(string url)
        {
            var request = new HttpRequestMessage(new HttpMethod("GET"), url);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public async Task<T> SendPostAsyncAsForm<T>(string url, string Params)
        {
            var bodyString = new StringContent(Params, Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await client.PostAsync(url, bodyString);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(responseBody);
            return result;
        }

        public async Task<T> SendPutAsync<T>(string url, object body)
        {
            string bodyStr = "";
            bodyStr = FormatBody(body);
            var bodyString = new StringContent(bodyStr, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url, bodyString);
            if (!response.IsSuccessStatusCode)
            {
                EventLogger.LogEvent(EventSeverity.Error, $"Failed put: {response.StatusCode} {await response.Content?.ReadAsStringAsync()} REQUEST: {bodyStr}");
            }
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(responseBody);
            return result;
        }

        private string FormatBody(object body)
        {
            string bodyStr = "";
            if (body.GetType() == typeof(string))
                bodyStr = body.ToString();
            else
                bodyStr = JsonConvert.SerializeObject(body);
            return bodyStr;
        }


    }
}
