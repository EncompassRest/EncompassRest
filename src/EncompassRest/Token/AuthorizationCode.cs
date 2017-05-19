using System;
using System.IO;
using System.Net;
using System.Text;

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
 * This class performs the user action by POSTing the Login Page content and credentials automatically to get an Authorization Code.
 * 
 * See the LoginPage class.
 */

namespace EncompassREST
{

    class AuthenticationCode
    {

        public static readonly string POST_BODY_ADAPTER_KEY = "pf.adapterId";

        public static readonly string POST_BODY_USERNAME_KEY = "pf.username";

        public static readonly string POST_BODY_PASSWORD_KEY = "pf.pass";

        public static readonly string POST_BODY_REMEMBER_KEY = "pf.rememberUsername";

        private LoginPage _page;

        private string _clientSecret;

        private string _basicAuthValue;

        private string _postUsername;
        private string _postPwd;

        private string _authCode;

        private string _processingMessage;

        public AuthenticationCode(LoginPage page, string clientSecret, string instanceID, string uid, string pwd)
        {
            _page = page;

            _basicAuthValue = "Basic " + HelperStatics.encodeAuthHeader(_page.ClientID, clientSecret, Encoding.UTF8);

            _clientSecret = clientSecret;

            _postUsername = uid + "@" + instanceID;

            _postPwd = pwd;
        }

        #region Properties

        public string Code
        {
            get
            {
                return _authCode;
            }
        }

        public string ProcessingMessage
        {
            get
            {
                return _processingMessage;
            }
        }

        #endregion

        #region Public Methods

        /*
         * This method will request an Authorization Code by POSTing the Login Page information and credentials then
         * process the response.
         * 
         * Returns 'true' if the request completed successfully and the response was processed, otherwise 'false'
         */
        public bool retrieveAuthCode()
        {
            bool retVal = false;

            HttpWebRequest loginPost = (HttpWebRequest)WebRequest.Create(_page.LoginPostURI);

            loginPost.Method = "POST";

            // prepare the headers
            loginPost.Headers.Add("Authorization", _basicAuthValue);
            loginPost.UserAgent = "API Early Adopter - Test Client v1.0 - jweinstock@homesteadfunding.com";
            loginPost.Referer = _page.LoginPageURI;
            loginPost.AllowAutoRedirect = false;
            loginPost.ContentType = "application/x-www-form-urlencoded";
            loginPost.CookieContainer = new CookieContainer();
            loginPost.CookieContainer.Add(new Uri(LoginPage.AUTH_DOMAIN), _page.Cookies);

            // prepare the post data
            byte[] postData = buildLoginPostBody(Encoding.UTF8);
            loginPost.ContentLength = postData.Length;

            Stream dataStream = loginPost.GetRequestStream();

            dataStream.Write(postData, 0, postData.Length);

            dataStream.Close();

            HttpWebResponse loginPostResp = (HttpWebResponse)loginPost.GetResponse();

            if (loginPostResp.StatusCode == HttpStatusCode.OK)
            {
                retVal = false;

                _processingMessage = buildProcessMessage("Posting Login Data", loginPostResp.StatusCode.ToString(), HelperStatics.convertResponseStream(loginPostResp.GetResponseStream(), Encoding.UTF8));
            }
            else if (loginPostResp.StatusCode == HttpStatusCode.Found)
            {
                retVal = processLoginPostResponse(loginPostResp, Encoding.UTF8);

                _processingMessage = buildProcessMessage("Posting Login Data", loginPostResp.StatusCode.ToString(), "Location is:  " + loginPostResp.Headers["Location"] + "\r\n\r\n" + HelperStatics.convertResponseStream(loginPostResp.GetResponseStream(), Encoding.UTF8));
            }
            else
            {
                retVal = false;

                _processingMessage = buildProcessMessage("Posting Login Data", loginPostResp.StatusCode.ToString(), HelperStatics.convertResponseStream(loginPostResp.GetResponseStream(), Encoding.UTF8));
            }

            loginPostResp.Close();

            return retVal;
        }

        #endregion

        #region Protected Methods

        protected bool processLoginPostResponse(HttpWebResponse loginPostResp, Encoding encoder)
        {
            string returnUri = loginPostResp.Headers["Location"];

            int startIdx = returnUri.IndexOf("code=") + 5;

            _authCode = returnUri.Substring(startIdx);

            return true;
        }

        protected byte[] buildLoginPostBody(Encoding encoder)
        {
            byte[] retArray = new byte[0];

            StringBuilder body = new StringBuilder();

            body.Append(POST_BODY_ADAPTER_KEY);
            body.Append("=");
            body.Append(WebUtility.UrlEncode(_page.AdapterID));
            body.Append("&");

            body.Append(POST_BODY_USERNAME_KEY);
            body.Append("=");
            body.Append(WebUtility.UrlEncode(_postUsername));
            body.Append("&");

            body.Append(POST_BODY_PASSWORD_KEY);
            body.Append("=");
            body.Append(WebUtility.UrlEncode(_postPwd));
            body.Append("&");

            return encoder.GetBytes(body.ToString());
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
