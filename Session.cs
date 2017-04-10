using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using EncompassREST.Exceptions;

namespace EncompassREST
{
    public class Session
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _instanceId;
        private readonly string _userId;
        private readonly string _password;
        //private string _SessionKey;
        private AccessToken _accessToken;
        private const string _apiUrl = "https://api.elliemae.com";
        private readonly HttpClient _client;

        private DateTime _tokenExpires;
        private DateTime _tokenLastCall;

        #region Properties
        public AccessToken AccessToken
        {
            get
            {
                return _accessToken;
            }
            private set
            {
                _accessToken = value;
                _tokenLastCall = DateTime.Now;

                IEnumerable<string> vals;
                if (_client.DefaultRequestHeaders.TryGetValues("Authorization", out vals))
                    _client.DefaultRequestHeaders.Remove("Authorization");
                _client.DefaultRequestHeaders.Add("Authorization", _accessToken.AuthenticationString);
            }
        }

        public Loans Loans { get; }

        public Schemas Schemas { get; }

        public Webhooks Webhooks { get; }

        public Reports Reports { get; }

        public Pipeline Pipeline { get; }

        public HttpClient RESTClient
        {
            get
            {
                if (_accessToken == null)
                    throw new SessionNotOpenException();

                var now = DateTime.Now;

                if ((now - _tokenLastCall).TotalMinutes > 12 ||
                    (_tokenExpires - now).TotalMinutes <10)
                {
                    ClearAccessToken();
                    StartSession();
                }

                _tokenLastCall = now;
                return _client;
            }
        }
        #endregion

        public Session(string clientId, string clientSecret, string instanceId, string userId, string password)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _instanceId = instanceId;
            _userId = userId;
            _password = password;

            _client = new HttpClient()
            {
                BaseAddress = new Uri(_apiUrl)
            };
            ServicePointManager.DefaultConnectionLimit = 100;

            _accessToken = null;
            Loans = new Loans(this);
            Schemas = new Schemas(this);
            Webhooks = new Webhooks(this);
            Reports = new Reports(this);
            Pipeline = new Pipeline(this);
        }

        public void StartSession()
        {
            var t = new AccessToken(_clientId, _clientSecret, _instanceId, this);
            t.GetTokenAsync(_userId, _password).Wait();
            AccessToken = t;
            var validate =  t.GetTokenValidationAsync().Result;
            _tokenExpires = validate.GetExpirationDate();
        }

        internal void ClearAccessToken()
        {
            _accessToken = null;
            _client.DefaultRequestHeaders.Remove("Authorization");
        }
    }
}
