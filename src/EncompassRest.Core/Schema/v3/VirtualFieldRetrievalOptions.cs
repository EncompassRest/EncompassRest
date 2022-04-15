using System.Collections.Generic;
using EncompassRest.Utilities;

namespace EncompassRest.Schema.v3
{
    /// <summary>
    /// The virtual field retrieval options.
    /// </summary>
    public sealed class VirtualFieldRetrievalOptions : Options
    {
        /// <summary>
        /// Filters the Virtual Fields list based on a single instance specifier type. 
        /// </summary>
        public StringEnumValue<InstanceSpecifierType> InstanceSpecifierType { get; set; }

        /// <summary>
        /// Filters the Virtual Fields list based on one or more virtual field types.
        /// </summary>
        public List<StringEnumValue<VirtualFieldType>>? VirtualFieldTypes { get; set; }

        internal override QueryParameters ToQueryParameters()
        {
            var queryParameters = base.ToQueryParameters();
            if (!string.IsNullOrEmpty(InstanceSpecifierType.Value))
            {
                queryParameters.Add("instanceSpecifierType", InstanceSpecifierType.Value);
            }
            if (VirtualFieldTypes?.Count > 0)
            {
                queryParameters.Add("virtualFieldTypes", string.Join(",", VirtualFieldTypes));
            }
            return queryParameters;
        }
    }
}