using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using XFSWDemo.Helpers;
using XFSWDemo.Model;

namespace XFSWDemo.Service
{
    public class BaseService<T>
    {
        protected string baseAddress;
        protected string securityToken;
        protected HttpClient m_HttpClient;

        public BaseService(string path, string securityToken)
        {
            this.baseAddress = Settings.API + path;
            // Storing the security token in a class property of type string    
            this.securityToken = securityToken.StartsWith("Bearer") ? securityToken.Substring(7) : securityToken;
            m_HttpClient = CreateHttpClient();
        }

        protected HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient()
            {
                MaxResponseContentBufferSize = 9999999,
                Timeout = new TimeSpan(0, 2, 0),
            };
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (!string.IsNullOrEmpty(securityToken))
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + securityToken);

            return httpClient;
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            try
            {
                // Get the response from the server url and REST path for the data  
                var response = await m_HttpClient.GetAsync(baseAddress);

                if (response.StatusCode == HttpStatusCode.Unauthorized)
                    throw new UnauthorizedAccessException("Access Denied");

                if (response.IsSuccessStatusCode)
                {
                    var results = JsonConvert.DeserializeObject<SearchResults<T>>(await response.Content.ReadAsStringAsync());
                    return results.Results;
                }

                throw new WebException(response.ReasonPhrase);
            }
            catch (Exception ex)
            {
                // TODO:        
                throw ex;
            }
        }

        public virtual async Task<T> Post(T entity)
        {
            try
            {
                // Get the response from the server url and REST path for the data  
                var response = await m_HttpClient.PostAsync(baseAddress,
                    new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json"));

                if (response.StatusCode == HttpStatusCode.Unauthorized)
                    throw new UnauthorizedAccessException("Access Denied");

                if (response.IsSuccessStatusCode)
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());

                throw new WebException(response.ReasonPhrase);
            }
            catch (Exception ex)
            {
                // TODO:        
                throw ex;
            }
        }
    }
}