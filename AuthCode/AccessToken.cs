using EncompassREST.Exceptions;
using EncompassREST.HelperClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;


namespace EncompassREST
{

    public class AccessToken
    {
        private static readonly string ACCESS_TOKEN_URLv2 = "https://api.elliemae.com/oauth2/v1/";

        private static HttpClient AuthClient;

        private string _clientID;
        private string _clientSecret;
        private string _Instance;

        private string _basicAuthValue;

        private TokenResponse _token;

        private Session _Session;


        public Session Session
        {
            get { return _Session; }
        }


        public AccessToken(string clientID, string clientSecret, string Instance, Session Session)
        {
            _Session = Session;
            AuthClient = new HttpClient();
            AuthClient.BaseAddress = new Uri(ACCESS_TOKEN_URLv2);

            _basicAuthValue = "Basic " + System.Convert.ToBase64String(Encoding.UTF8.GetBytes(clientID + ":" + clientSecret));
            AuthClient.DefaultRequestHeaders.Add("Authorization", _basicAuthValue);
            

            _clientID = clientID;
            _clientSecret = clientSecret;
            _Instance = Instance;
        }


        #region Properties

        
        public string Token
        {
            get
            {
                return _token.AccessToken;
            }
        }

        public string Type
        {
            get
            {
                return _token.TokenType;
            }
        }

        #endregion

        #region Public Methods

        public string AuthenticationString
        {
            get { return Type + " " + Token; }
        }
        

        public async Task<TokenValidateResponse> getTokenValidation()
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, "token/introspection");
            RequestParameters rp = new RequestParameters();
            rp.Add("token", _token.AccessToken);

            //message.Headers.Authorization = new AuthenticationHeaderValue(_basicAuthValue);

            message.Content = rp.buildPostContent();
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var response = await AuthClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TokenValidateResponse>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new RESTException("getTokenValidation", response);
            }
        }

        public async Task<bool> deleteToken()
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, "token/revocation");
            //message.Headers.Authorization = new AuthenticationHeaderValue(_basicAuthValue);

            RequestParameters rp = new RequestParameters();
            rp.Add("token", _token.AccessToken);

            message.Content = rp.buildPostContent();
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            var response = await AuthClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
                return true;
            else
            {
                throw new RESTException("deleteToken", response);
            }
        }

        public async Task<bool> getToken(string username, string password)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, "token");
            //message.Headers.Add("Authorization",_basicAuthValue);

            RequestParameters rp = new RequestParameters();
            rp.Add("grant_type", "password");
            rp.Add("username", string.Format("{0}@encompass:{1}", username, _Instance));
            rp.Add("password",password);


            message.Content = rp.buildPostContent();
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var response  =  await AuthClient.SendAsync(message);

            //var response = await AuthClient.PostAsync("token", rp.buildPostContent());


            if (response.IsSuccessStatusCode)
            {
                string tokenData = await response.Content.ReadAsStringAsync();
                var tr = JsonConvert.DeserializeObject<TokenResponse>(tokenData);
                _token = tr;
                return true;
            }
            else
            {
                throw new RESTException("getToken", response);
            }
            
        }
        

        #endregion
        
    }
}
