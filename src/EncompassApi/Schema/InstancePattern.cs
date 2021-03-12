using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace EncompassApi.Schema
{
    /// <summary>
    /// InstancePattern
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InstancePattern : ExtensibleObject
    {
        /// <summary>
        /// InstancePattern IndexOffset
        /// </summary>
        public int IndexOffset { get; set; }

        /// <summary>
        /// InstancePattern IndexToken
        /// </summary>
        public string? IndexToken { get; set; }

        /// <summary>
        /// InstancePattern MaxIndex
        /// </summary>
        public int MaxIndex { get; set; }

        /// <summary>
        /// InstancePattern Match
        /// </summary>
        public Dictionary<string, string>? Match { get; set; }
    }
}