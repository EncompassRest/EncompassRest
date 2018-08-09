using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CrmLog
    /// </summary>
    public sealed partial class CrmLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _contactGuid;
        /// <summary>
        /// CrmLog ContactGuid
        /// </summary>
        public string ContactGuid { get => _contactGuid; set => _contactGuid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// CrmLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _mappingId;
        /// <summary>
        /// CrmLog MappingId
        /// </summary>
        public string MappingId { get => _mappingId; set => _mappingId = value; }
        private DirtyValue<int?> _mappingType;
        /// <summary>
        /// CrmLog MappingType
        /// </summary>
        public int? MappingType { get => _mappingType; set => _mappingType = value; }
        private DirtyValue<int?> _roleType;
        /// <summary>
        /// CrmLog RoleType
        /// </summary>
        public int? RoleType { get => _roleType; set => _roleType = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// CrmLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
    }
}