using EncompassApi.Configuration;
using EncompassApi.MessageHandlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.FuncApp.Configuration
{
    public static class ConfigHelper
    {
        public static EncompassTokenClientOptions GetEncompassTokenClientOptions()
        {
            return new EncompassTokenClientOptions
            {
                BaseUrl = GetStringValue("EncompassTokenClient:BaseUrl"),
                ClientId = GetStringValue("EncompassTokenClient:ClientId"),
                ClientName = GetStringValue("EncompassTokenClient:ClientName"),
                ClientSecret = GetStringValue("EncompassTokenClient:ClientSecret"),
                EncompassInstanceId = GetStringValue("EncompassTokenClient:EncompassInstanceId"),
                Password = GetStringValue("EncompassTokenClient:Password"),
                Username = GetStringValue("EncompassTokenClient:Username"),
                Retry = GetBoolValue("EncompassTokenClient:Retry", true),
                RetryCount = GetIntValue("EncompassTokenClient:RetryCount", 3),
                TimeoutInSeconds = GetIntValue("EncompassTokenClient:TimeoutInSeconds", 30)
            };
        }

        public static FairwayTokenClientOptions GetFairwayTokenClientOptions()
        {
            return new FairwayTokenClientOptions
            {
                BaseUrl = GetStringValue("FairwayTokenClient:BaseUrl"),
                ClientId = GetStringValue("FairwayTokenClient:ClientId"),
                ClientName = GetStringValue("FairwayTokenClient:ClientName"),
                ClientSecret = GetStringValue("FairwayTokenClient:ClientSecret"),
                HostKey = GetStringValue("w9SojZeo2TLvE7aXadnyUJ9aoP1RZJjT8JjG3oE7jDwqCPxYar9C4g=="),
                Retry = GetBoolValue("FairwayTokenClient:Retry", true),
                RetryCount = GetIntValue("FairwayTokenClient:RetryCount", 3),
                TimeoutInSeconds = GetIntValue("FairwayTokenClient:TimeoutInSeconds", 30)
            };
        }

        public static BaseHttpClientOptions GetEncompassClientOptions()
        {
            return new BaseHttpClientOptions
            {
                BaseUrl = GetStringValue("EncompassClient:BaseUrl"),
                ClientName = GetStringValue("EncompassClient:ClientName"),
                Retry = GetBoolValue("EncompassClient:Retry", true),
                RetryCount = GetIntValue("EncompassClient:RetryCount", 3),
                TimeoutInSeconds = GetIntValue("EncompassClient:TimeoutInSeconds", 30)
            };
        }

        private static string GetStringValue(string name)
        {
            return Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Process);
        }

        private static int GetIntValue(string name, int defaultValue)
        {
            if (!int.TryParse(GetStringValue(name), out int value))
            {
                value = defaultValue;
            }

            return value;
        }

        private static bool GetBoolValue(string name, bool defaultValue)
        {
            if (!bool.TryParse(GetStringValue(name), out bool value))
            {
                value = defaultValue;
            }

            return value;
        }
    }
}
