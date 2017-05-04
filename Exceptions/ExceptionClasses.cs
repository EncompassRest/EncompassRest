using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace EncompassRest.Exceptions
{
    public class FileNotFoundException : Exception
    {
        public string ExtraData { get; }

        public FileNotFoundException(string message, string extraData) : base(message)
        {
            ExtraData = extraData;
        }
    }

    public class LoanLockedException : RestException
    {
        public LoanLocked LoanLocked { get; }

        public LoanLockedException(string message, HttpResponseMessage response) : base(message, response)
        {
            var value =  response.Content.ReadAsStringAsync().Result;
            LoanLocked = JsonConvert.DeserializeObject<LoanLocked>(value);
        }
    }

    public class RestException : Exception
    {
        private HttpResponseMessage _response;

        public HttpStatusCode StatusCode => _response.StatusCode;

        public HttpResponseMessage Response => _response;

        public string Content => _response.Content.ReadAsStringAsync().Result;

        public string CorrelationId
        {
            get
            {
                var corr = _response.Headers.Where(x => x.Key == "X-Correlation-ID").Select(x => x.Value).FirstOrDefault();
                if (corr != null)
                    return corr.FirstOrDefault();
                else
                    return "NA";
            }
        }

        public RestException(string message, HttpResponseMessage Response) : base(BaseMessageBuilder(message, Response))
        {
            _response = Response;
        }

        private static string BaseMessageBuilder(string message, HttpResponseMessage Response)
        {
            var errorString = new StringBuilder();

            if (message != "")
            {
                errorString.Append(message);
                errorString.Append(Environment.NewLine);
            }

            if (!Response.IsSuccessStatusCode)
            {
                /**/
                HttpError error = Response.Content.ReadAsAsync<HttpError>().Result;
                if (error != null)
                {
                    errorString.Append(error.Message);
                    errorString.Append(Environment.NewLine);

                    if ((error.InnerException != null))
                    {
                        errorString.Append(error.InnerException.Message);
                        errorString.Append(Environment.NewLine);
                    }

                    errorString.Append(error.StackTrace);
                }
                /**/
                //errorString.Append(Response.Content.ReadAsStringAsync().Result);
            }
            return errorString.ToString();
        }
    }

    public class SessionNotOpenException : Exception
    {
    }

    public class InvalidEntitiesException : Exception
    {
        public IEnumerable<string> InvalidEntitiesList { get; }

        public InvalidEntitiesException(IEnumerable<string> invalidEntitiesList)
        {
            InvalidEntitiesList = invalidEntitiesList;
        }
    }
}
