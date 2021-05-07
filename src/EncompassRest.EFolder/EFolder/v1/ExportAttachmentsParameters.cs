using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.EFolder.v1
{
    /// <summary>
    /// ExportAttachmentsParameters
    /// </summary>
    public sealed class ExportAttachmentsParameters : ExtensibleObject
    {
        /// <summary>
        /// ExportAttachmentsParameters AnnotationSettings
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AnnotationSettings? AnnotationSettings { get; set; }

        /// <summary>
        /// ExportAttachmentsParameters Source
        /// </summary>
        public EntityReference Source { get; }

        /// <summary>
        /// ExportAttachmentsParameters Entities
        /// </summary>
        public IList<EntityReference> Entities { get; }

        /// <summary>
        /// ExportAttachmentsParameters constructor.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="entities"></param>
        public ExportAttachmentsParameters(EntityReference source, params EntityReference[] entities)
            : this(source, (IEnumerable<EntityReference>)entities)
        {
        }

        /// <summary>
        /// ExportAttachmentsParameters constructor.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="entities"></param>
        public ExportAttachmentsParameters(EntityReference source, IEnumerable<EntityReference> entities)
        {
            Preconditions.NotNull(source, nameof(source));
            Preconditions.NotNullOrEmpty(entities, nameof(entities));

            Source = source;
            Entities = new ReadOnlyCollection<EntityReference>(entities.ToList());
        }
    }
}
