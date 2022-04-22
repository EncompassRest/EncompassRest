﻿using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Settings.Loan.v1
{
    /// <summary>
    /// FieldAudit
    /// </summary>
    public sealed class FieldAudit : ExtensibleObject
    {
        /// <summary>
        /// Provide the field ID for which to display the audit information or data.
        /// </summary>
        [JsonRequired]
        public string FieldId { get; set; }

        /// <summary>
        /// The type of last-change information to display.
        /// </summary>
        public StringEnumValue<AuditData> Data { get; set; }

        /// <summary>
        /// FieldAudit constructor.
        /// </summary>
        /// <param name="fieldId">Provide the field ID for which to display the audit information or data.</param>
        /// <param name="data">The type of last-change information to display.</param>
        public FieldAudit(string fieldId, AuditData data)
            : this(fieldId, data.Validate(nameof(data)).GetValue())
        {
        }

        /// <summary>
        /// FieldAudit constructor.
        /// </summary>
        /// <param name="fieldId">Provide the field ID for which to display the audit information or data.</param>
        /// <param name="data">The type of last-change information to display.</param>
        [JsonConstructor]
        public FieldAudit(string fieldId, string data)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNullOrEmpty(data, nameof(data));

            FieldId = fieldId;
            Data = data;
        }
    }
}