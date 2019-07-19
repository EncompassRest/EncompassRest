using System.Net.Http;
using System.Threading.Tasks;
namespace EncompassRest
{
    /// <summary>
    /// Interace for Implementing HTTP Logging. 
    /// Supported in netstandard2.0, net45, net46
    /// </summary>
    public interface IHttpRequestLogger
    {
        /// <summary>
        /// Logs the HTTP request message
        /// </summary>
        /// <param name="httpRequestMessage"></param>
        /// <returns>
        /// Returns the Id of the Http Request Log
        /// </returns>
        Task<string> LogHttpRequestMessageAsync(HttpRequestMessage httpRequestMessage);

        /// <summary>
        /// Logs the HTTP response message
        /// </summary>
        /// <param name="httpResponseMessage"></param>
        /// <param name="httpRequestMessageLog">Value returned from LogHttpRequestMessage</param>
        /// <returns>Returns the Id of the Http Response Log</returns>
        Task<string> LogHttpResponseMessageAsync(HttpResponseMessage httpResponseMessage, string httpRequestMessageLog);
    }
}
