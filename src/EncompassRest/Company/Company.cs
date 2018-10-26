using System.Threading;

namespace EncompassRest.Company
{
    /// <summary>
    /// Company Apis
    /// </summary>
    public sealed class Company : ApiObject
    {
        private Users.Users _users;
        private GlobalCustomDataObjects _globalCustomDataObjects;

        /// <summary>
        /// Users Apis
        /// </summary>
        public Users.Users Users
        {
            get
            {
                var users = _users;
                return users ?? Interlocked.CompareExchange(ref _users, (users = new Users.Users(Client)), null) ?? users;
            }
        }

        /// <summary>
        /// Global Custom Data Objects Apis
        /// </summary>
        public GlobalCustomDataObjects GlobalCustomDataObjects
        {
            get
            {
                var globalCustomDataObjects = _globalCustomDataObjects;
                return globalCustomDataObjects ?? Interlocked.CompareExchange(ref _globalCustomDataObjects, (globalCustomDataObjects = new GlobalCustomDataObjects(Client)), null) ?? globalCustomDataObjects;
            }
        }

        internal Company(EncompassRestClient client)
            : base(client, "encompass/v1/company")
        {
        }
    }
}