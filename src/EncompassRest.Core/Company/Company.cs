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
        /// Global Custom Data Objects Apis
        /// </summary>
        IGlobalCustomDataObjects GlobalCustomDataObjects { get; }
        /// <summary>
        /// Users Apis
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