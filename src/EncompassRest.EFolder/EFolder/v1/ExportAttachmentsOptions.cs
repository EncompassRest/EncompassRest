﻿using EncompassRest.Utilities;

namespace EncompassRest.EFolder.v1
{
    /// <summary>
    /// ExportAttachmentsOptions
    /// </summary>
    public sealed class ExportAttachmentsOptions : Options
    {
        /// <summary>
        /// ExportAttachmentsOptions IncludeNotActive
        /// </summary>
        public bool? IncludeNotActive { get; set; }

        /// <summary>
        /// ExportAttachmentsOptions ErrorOnBackgroundAttachment
        /// </summary>
        public bool? ErrorOnBackgroundAttachment { get; set; }

        /// <summary>
        /// ExportAttachmentsOptions PolicyId
        /// </summary>
        public string? PolicyId { get; set; }

        /// <summary>
        /// ExportAttachmentsOptions Priority
        /// </summary>
        public bool? Priority { get; set; }

        internal override QueryParameters ToQueryParameters()
        {
            var queryParameters = base.ToQueryParameters();
            if (IncludeNotActive.HasValue)
            {
                queryParameters.Add("includeNotActive", IncludeNotActive.ToString());
            }
            if (ErrorOnBackgroundAttachment.HasValue)
            {
                queryParameters.Add("errorOnBackgroundAttachment", ErrorOnBackgroundAttachment.ToString());
            }
            if (!string.IsNullOrEmpty(PolicyId))
            {
                queryParameters.Add("policyId", PolicyId);
            }
            if (Priority.HasValue)
            {
                queryParameters.Add("priority", Priority.ToString());
            }
            return queryParameters;
        }
    }
}