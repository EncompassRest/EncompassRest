using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/*
 * The Open APIs will use 2 Factor Authentication to secure access to the interfaces.  The delivered Early Adopter security mechanism supports those 
 * scenarios where users need to provide credentials prior to gaining an Authorization Code.  In these scenarios a
 * user will navigate to the Authorization Code URL, the system will respond with a Login Page.  The Login Page contains dynamic information 
 * needed to gain the Authorization Code.  The dynamic information on the Login Page needed for the Authorization Code is:
 * 
 *      - The EM HTTP cookie
 *      - The form Post URI
 *      - The AdapterID
 * 
 * When the user enters the information into the Login Page and clicks the "Login" button, all the needed information is POSTed to get the Authorization 
 * Code.  The Authorization Code will be delivered to a Redirect URL.  The application at the Redirect URL location will need to contain 
 * the functionality that can request an Access Token using the Authorization Code.
 * 
 * This class loads the Login Page and process the response.  This class needs to be passed into the Authentication
 * 
 */
namespace EncompassREST
{

    class LoginPage
    {
        private string _clientID;

        private string _loginPageURI;
        private string _loginPostURI;

        private CookieCollection _cookies;

        private string _adapterId;

        private string _processingMessage;

        public static readonly string AUTH_DOMAIN = "https://idp.elliemae.com/";
        public static readonly string AUTH_PATH = "authorize";
        public static readonly string RESPONSE_TYPE_PARAM = "response_type=code";
        public static readonly string REDIRECT_URI_PARAM = "redirect_uri=http%3a%2f%2fwww.example.com%2f";
        public static readonly string REDIRECT_URL = "http://www.example.com/";

        public LoginPage(string clientID)
        {
            _clientID = clientID;

            _loginPageURI = AUTH_DOMAIN + AUTH_PATH + "?client_id=" + _clientID + "&" + RESPONSE_TYPE_PARAM + "&" + REDIRECT_URI_PARAM;
        }

        #region Properties

        public string ClientID
        {
            get
            {
                return _clientID;
            }
        }

        public string LoginPageURI
        {
            get
            {
                return _loginPageURI;
            }
        }

        public string LoginPostURI
        {
            get
            {
                return _loginPostURI;
            }
        }

        public CookieCollection Cookies
        {
            get
            {
                return _cookies;
            }
        }

        public string AdapterID
        {
            get
            {
                return _adapterId;
            }
        }

        // this is just a helper property to communicate status
        public string ProcessingMessage
        {
            get
            {
                return _processingMessage;
            }
        }

        public string RedirectURI
        {
            get
            {
                return REDIRECT_URL;
            }
        }

        #endregion

        #region Public Methods

        /*
         * This method will make the request for the Login page based on the Client ID and then
         * process the Login Page response.
         * 
         * Returns 'true' if the page was loaded and the response was processed, otherwise 'false'
         */
        public bool processLoginPage()
        {
            bool retVal = false;

            HttpWebRequest loginReq = (HttpWebRequest)WebRequest.Create(_loginPageURI);

            loginReq.UserAgent = "API Early Adopter - Test Client v1.0 - jweinstock@homesteadfunding.com";

            loginReq.AllowAutoRedirect = false;

            HttpWebResponse loginResp = (HttpWebResponse)loginReq.GetResponse();

            if (loginResp.StatusCode == HttpStatusCode.OK)
            {
                retVal = processLoginResponse(loginResp, Encoding.UTF8);
            }
            else if (loginResp.StatusCode == HttpStatusCode.Found)
            {
                retVal = false;

                _processingMessage = buildProcessMessage("Processing Login Page", loginResp.StatusCode.ToString(), "Location is:  " + loginResp.Headers["Location"]);
            }
            else
            {
                retVal = false;

                _processingMessage = buildProcessMessage("Processing Login Page", loginResp.StatusCode.ToString(), HelperStatics.convertResponseStream(loginResp.GetResponseStream(), Encoding.UTF8));
            }

            loginResp.Close();

            return retVal;
        }

        #endregion

        #region Protected Methods

        /*
         * This is the method that parses the page and collects the cookie form the response.
         * 
         * Returns 'true' if the response was processed successfully, otherwise 'false'
         */
        protected bool processLoginResponse(HttpWebResponse loginResp, Encoding encode)
        {
            bool returnVal = false;

            //_cookies = getCookieCollection( loginResp.Headers.Get(HttpResponseHeader.SetCookie.ToString()) );

            _cookies = getCookieCollection(loginResp.Headers.GetValues("Set-Cookie"));

            string responseBody = HelperStatics.convertResponseStream(loginResp.GetResponseStream(), encode);

            // Check to make sure that the response has the data needed for the post
            // Needed data is:
            //     cookie
            //     adapterID
            //     loginPostURL
            if (_cookies != null && _cookies.Count > 0)
            {
                _loginPostURI = getPostUri(responseBody);

                if (_loginPostURI != null && _loginPostURI.Length > 0)
                {
                    _adapterId = getAdapterValue(responseBody);

                    if (_adapterId != null && _adapterId.Length > 0)
                    {
                        returnVal = true;
                    }
                    else
                    {
                        returnVal = false;

                        _processingMessage = buildProcessMessage("Processing Login Page", loginResp.StatusCode.ToString(), responseBody);
                    }
                }
                else
                {
                    returnVal = false;

                    _processingMessage = buildProcessMessage("Processing Login Page", loginResp.StatusCode.ToString(), responseBody);
                }
            }
            else
            {
                returnVal = false;

                _processingMessage = buildProcessMessage("Processing Login Page", loginResp.StatusCode.ToString(), responseBody);
            }

            return returnVal;
        }

        protected CookieCollection getCookieCollection(string[] cookieList)
        {
            CookieCollection cookies = new CookieCollection();

            if (cookieList != null)
            {
                for (int idx = 0; idx < cookieList.Length; idx++)
                {
                    string[] cookieParts = cookieList[idx].Split(';');

                    //Create the cookie with the first item
                    Cookie newCookie = new Cookie(cookieParts[0].Split('=')[0], cookieParts[0].Split('=')[1]);

                    for (int partIdx = 1; partIdx < cookieParts.Length; partIdx++)
                    {
                        string part = cookieParts[partIdx];

                        if (part.IndexOf('=') >= 0)
                        {
                            string[] cookieParam = part.Split('=');

                            if (cookieParam[0] == "Path")
                            {
                                newCookie.Path = cookieParam[1];
                            }
                            else if (cookieParam[0] == "Domain")
                            {
                                newCookie.Domain = cookieParam[1];
                            }
                        }
                        else
                        {
                            if (part == "Secure")
                            {
                                newCookie.Secure = true;
                            }
                            else if (part == "HttpOnly")
                            {
                                newCookie.HttpOnly = true;
                            }
                        }
                    }

                    cookies.Add(newCookie);
                }
            }

            return cookies;
        }

        protected string getAdapterValue(string response)
        {
            string adapterStartToken = "name=\"pf.adapterId\" value=\"";
            string adapterEndToken = "\"/>";

            int startIdx = response.IndexOf(adapterStartToken) + adapterStartToken.Length;
            int endIdx = response.IndexOf(adapterEndToken, startIdx);

            return response.Substring(startIdx, endIdx - startIdx);
        }

        protected string getPostUri(string response)
        {
            string urlStart = "https://idp.elliemae.com/as/";
            string urlCodeStartToken = "<form method=\"POST\" action=\"/as/";
            string urlCodeEndToken = "/resume/as/authorization.ping";

            int startIdx = response.IndexOf(urlCodeStartToken) + urlCodeStartToken.Length;
            int endIdx = response.IndexOf(urlCodeEndToken, startIdx);

            return urlStart + response.Substring(startIdx, endIdx - startIdx) + urlCodeEndToken;
        }

        protected string buildProcessMessage(string firstLine, string respCode, string response)
        {
            StringBuilder processMsg = new StringBuilder(firstLine);
            processMsg.Append("\r\n\r\n");
            processMsg.Append("Response Code: ");
            processMsg.Append(respCode);
            processMsg.Append("\r\n\r\n");
            processMsg.Append(response);

            return processMsg.ToString();
        }

        #endregion

    }
}
