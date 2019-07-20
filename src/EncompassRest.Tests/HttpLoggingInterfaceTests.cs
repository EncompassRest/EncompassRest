using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System;

namespace EncompassRest.Tests
{
    public class HttpLoggingInterfaceImplementation : IHttpRequestLogger
    {
        public Task<string> LogHttpRequestMessageAsync(HttpRequestMessage httpRequestMessage)
        {
            return Task.FromResult("Called LogHttpRequestMessageAsync");
        }

        public Task<string> LogHttpResponseMessageAsync(HttpResponseMessage httpResponseMessage, string httpRequestMessageLog)
        {
            return Task.FromResult("Called LogHttpResponseMessageAsync");
        }
    }

    [TestClass]
    public class HttpLoggingInterfaceTests
    {
#if NETCOREAPP1_1
#else
        private Type apiObjectType;
        private MethodInfo apiObjectGetHttpRequestLoggerMethod;
        private FieldInfo isUsingCustomHttpLogger;

        public HttpLoggingInterfaceTests()
        {
            apiObjectType = Type.GetType("EncompassRest.ApiObject, EncompassRest", true, false);

            apiObjectGetHttpRequestLoggerMethod = apiObjectType.GetMethod("GetHttpRequestLogger", BindingFlags.Static | BindingFlags.NonPublic);

            isUsingCustomHttpLogger = apiObjectType.GetField("IsUsingCustomHttpLogger", BindingFlags.Static | BindingFlags.NonPublic);
        }

        private void HttpLoggingInterface_ModifyAppSettings(string key, string value)
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(Assembly.GetCallingAssembly().Location);
            var appSettingsSection = (System.Configuration.AppSettingsSection)config.GetSection("appSettings");
            appSettingsSection.Settings.Clear();
            appSettingsSection.Settings.Add(key, value);
            config.Save();
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }

        [TestMethod]
        public void HttpLoggingInterface_GetHttpRequestLoggerWithInterface()
        {
            isUsingCustomHttpLogger.SetValue(null, true);
            HttpLoggingInterface_ModifyAppSettings("HttpLoggingAssembly", "EncompassRest.Tests.dll");
            Assert.IsInstanceOfType(apiObjectGetHttpRequestLoggerMethod.Invoke(null, null), typeof(IHttpRequestLogger));
        }

        [TestMethod]
        public void HttpLoggingInterface_GetHttpRequestLoggerWithOutInterface()
        {
            isUsingCustomHttpLogger.SetValue(null, false);
            HttpLoggingInterface_ModifyAppSettings("HttpLoggingAssembly", "");
            Assert.IsNull(apiObjectGetHttpRequestLoggerMethod.Invoke(null, null));
        }
#endif
    }
}
