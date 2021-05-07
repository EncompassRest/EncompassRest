using System.Threading;
using EncompassRest.Company.Users;

namespace EncompassRest.Company
{
    /// <summary>
    /// Company Apis
    /// </summary>
    public interface ICompany : IApiObject
    {
        /// <summary>
        /// Global Custom Data Objects Apis exposed as extension methods
        /// within the EncompassRest.Company.v1 namespace.
        /// </summary>
        IGlobalCustomDataObjects GlobalCustomDataObjects { get; }
        /// <summary>
        /// The Users Apis exposed as extension methods from the EncompassRest.Users package
        /// within the EncompassRest.Company.Users.v1 namespace.
        /// </summary>
        IUsers Users { get; }
    }

    internal sealed class Company : ApiObject, ICompany
    {
        private Users.Users? _users;
        private GlobalCustomDataObjects? _globalCustomDataObjects;

        public IUsers Users
        {
            get
            {
                var users = _users;
                return users ?? Interlocked.CompareExchange(ref _users, (users = new Users.Users(Client)), null) ?? users;
            }
        }

        public IGlobalCustomDataObjects GlobalCustomDataObjects
        {
            get
            {
                var globalCustomDataObjects = _globalCustomDataObjects;
                return globalCustomDataObjects ?? Interlocked.CompareExchange(ref _globalCustomDataObjects, (globalCustomDataObjects = new GlobalCustomDataObjects(Client)), null) ?? globalCustomDataObjects;
            }
        }

        internal Company(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}