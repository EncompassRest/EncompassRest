using EncompassREST.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST
{
    public class Session
    {
        private string _ClientID;
        private string _ClientSecret;
        private string _InstanceID;
        private string _UserID;
        private string _Password;

        //private string _SessionKey;
        private AccessToken _AccessToken;

        private string API_URL = "https://api.elliemae.com";

        private HttpClient _client;

        private Loans loans;
        private Schemas schemas;
        private Webhooks webhooks;
        private Reports reports;
        private Pipeline pipeline;

        #region properties
        public AccessToken AccessToken
        {
            get { return _AccessToken; }
            private set
            {
                _AccessToken = value;
                
                IEnumerable<string> vals;
                if (_client.DefaultRequestHeaders.TryGetValues("Authorization",out vals))
                    _client.DefaultRequestHeaders.Remove("Authorization");
                _client.DefaultRequestHeaders.Add("Authorization", _AccessToken.AuthenticationString);
            }
        }

        

        public Loans Loans
        {
            get { return loans; }
        }

        public Schemas Schemas
        {
            get { return schemas; }
        }

        public Webhooks Webhooks
        {
            get { return webhooks; }
        }

        public Reports Reports
        {
            get { return reports; }
        }

        public Pipeline Pipeline
        {
            get { return pipeline; }
        }

        public HttpClient RESTClient
        {
            get
            {
                if (_AccessToken == null)
                    throw new SessionNotOpenException();
                return _client;
            }
        }
        #endregion

        public Session(string ClientID,
                        string ClientSecret,
                        string InstanceID,
                        string UserID,
                        string Password)
        {
            _ClientID = ClientID;
            _ClientSecret = ClientSecret;
            _InstanceID = InstanceID;
            _UserID = UserID;
            _Password = Password;

            _client = new HttpClient();
            _client.BaseAddress = new Uri(API_URL);
            ServicePointManager.DefaultConnectionLimit =100;

            _AccessToken = null;

            loans = new Loans(this);
            schemas = new Schemas(this);
            webhooks = new Webhooks(this);
            reports = new Reports(this);
            pipeline = new Pipeline(this);

        }

        public void StartSession()
        {

            var t = new AccessToken(_ClientID, _ClientSecret, _InstanceID, this);

            t.getToken(_UserID, _Password).Wait();
            AccessToken = t;

        }
        

        internal void ClearAccessToken()
        {
            _AccessToken = null;
            _client.DefaultRequestHeaders.Remove("Authorization");
        }

    }
}
