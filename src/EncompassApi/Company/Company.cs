using System.Threading;

namespace EncompassApi.Company
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
        Users.IUsers Users { get; }
    }

    /// <summary>
    /// Company Apis
    /// </summary>
    public sealed class Company : ApiObject, ICompany
    {
        private Users.Users? _users;
        private GlobalCustomDataObjects? _globalCustomDataObjects;

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

        Users.IUsers ICompany.Users => Users;

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

        IGlobalCustomDataObjects ICompany.GlobalCustomDataObjects => GlobalCustomDataObjects;

        internal Company(EncompassApiClient client)
            : base(client, "encompass/v1/company")
        {
        }
    }
}