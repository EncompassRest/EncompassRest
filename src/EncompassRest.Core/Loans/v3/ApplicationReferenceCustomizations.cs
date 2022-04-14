using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace EncompassRest.Loans.v3
{
    public sealed partial class ApplicationReference : EntityReference
    {
        /// <summary>
        /// ApplicationReference constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public ApplicationReference(string entityId, EntityType entityType)
            : base(entityId, entityType)
        {
        }

        /// <summary>
        /// ApplicationReference constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public ApplicationReference(string entityId, string entityType)
            : base(entityId, entityType)
        {
        }

        /// <summary>
        /// ApplicationReference deserialization constructor.
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public ApplicationReference()
        {
        }
    }
}