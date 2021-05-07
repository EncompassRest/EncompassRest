using System.Threading;
using EncompassRest.Company.Users.Rights;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Apis
    /// </summary>
    public interface IUserApis : IUserApiObject
    {
        /// <summary>
        /// User Compensation Apis exposed as extension methods from the EncompassRest.Users package
        /// within the EncompassRest.Company.Users.v1 namespace.
        /// </summary>
        IUserCompensationPlans Compensation { get; }
        /// <summary>
        /// User Custom Data Objects Apis exposed as extension methods from the EncompassRest.Users package
        /// within the EncompassRest.Company.Users.v1 namespace.
        /// </summary>
        IUserCustomDataObjects CustomDataObjects { get; }
        /// <summary>
        /// User Groups Apis exposed as extension methods from the EncompassRest.Users package
        /// within the EncompassRest.Company.Users.v1 namespace.
        /// </summary>
        IUserGroups Groups { get; }
        /// <summary>
        /// User Licenses Apis exposed as extension methods from the EncompassRest.Users package
        /// within the EncompassRest.Company.Users.v1 namespace.
        /// </summary>
        IUserLicenseDetails Licenses { get; }
        /// <summary>
        /// User Rights Apis exposed as extension methods from the EncompassRest.Users package
        /// within the EncompassRest.Company.Users.Rights.v1 namespace.
        /// </summary>
        IUsersRights Rights { get; }
    }

    internal sealed class UserApis : UserApiObject, IUserApis
    {
        private UserCustomDataObjects? _customDataObjects;
        private UserGroups? _groups;
        private UserCompensationPlans? _compensation;
        private UserLicenseDetails? _licenses;
        private UsersRights? _rights;

        public IUserCustomDataObjects CustomDataObjects
        {
            get
            {
                var customDataObjects = _customDataObjects;
                return customDataObjects ?? Interlocked.CompareExchange(ref _customDataObjects, (customDataObjects = new UserCustomDataObjects(Client, this, UserId)), null) ?? customDataObjects;
            }
        }

        public IUserGroups Groups
        {
            get
            {
                var groups = _groups;
                return groups ?? Interlocked.CompareExchange(ref _groups, (groups = new UserGroups(Client, this, UserId)), null) ?? groups;
            }
        }

        public IUserCompensationPlans Compensation
        {
            get
            {
                var compensation = _compensation;
                return compensation ?? Interlocked.CompareExchange(ref _compensation, (compensation = new UserCompensationPlans(Client, this, UserId)), null) ?? compensation;
            }
        }

        public IUserLicenseDetails Licenses
        {
            get
            {
                var licenses = _licenses;
                return licenses ?? Interlocked.CompareExchange(ref _licenses, (licenses = new UserLicenseDetails(Client, this, UserId)), null) ?? licenses;
            }
        }

        public IUsersRights Rights
        {
            get
            {
                var rights = _rights;
                return rights ?? Interlocked.CompareExchange(ref _rights, (rights = new UsersRights(Client, this, UserId)), null) ?? rights;
            }
        }

        internal UserApis(EncompassRestClient client, string userId)
            : base(client, null!, userId, null)
        {
        }
    }
}