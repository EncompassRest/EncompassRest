using System.Threading;
using EncompassRest.Company.Users.Rights;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Apis
    /// </summary>
    public sealed class UserApis : UserApiObject
    {
        private UserCustomDataObjects _customDataObjects;
        private UserGroups _groups;
        private UserCompensationPlans _compensation;
        private UserLicenseDetails _licenses;
        private UsersRights _rights;

        /// <summary>
        /// User Custom Data Objects Apis
        /// </summary>
        public UserCustomDataObjects CustomDataObjects
        {
            get
            {
                var customDataObjects = _customDataObjects;
                return customDataObjects ?? Interlocked.CompareExchange(ref _customDataObjects, (customDataObjects = new UserCustomDataObjects(Client, UserId)), null) ?? customDataObjects;
            }
        }

        /// <summary>
        /// User Groups Apis
        /// </summary>
        public UserGroups Groups
        {
            get
            {
                var groups = _groups;
                return groups ?? Interlocked.CompareExchange(ref _groups, (groups = new UserGroups(Client, UserId)), null) ?? groups;
            }
        }

        /// <summary>
        /// User Compensation Apis
        /// </summary>
        public UserCompensationPlans Compensation
        {
            get
            {
                var compensation = _compensation;
                return compensation ?? Interlocked.CompareExchange(ref _compensation, (compensation = new UserCompensationPlans(Client, UserId)), null) ?? compensation;
            }
        }

        /// <summary>
        /// User Licenses Apis
        /// </summary>
        public UserLicenseDetails Licenses
        {
            get
            {
                var licenses = _licenses;
                return licenses ?? Interlocked.CompareExchange(ref _licenses, (licenses = new UserLicenseDetails(Client, UserId)), null) ?? licenses;
            }
        }

        /// <summary>
        /// User Rights Apis
        /// </summary>
        public UsersRights Rights
        {
            get
            {
                var rights = _rights;
                return rights ?? Interlocked.CompareExchange(ref _rights, (rights = new UsersRights(Client, UserId)), null) ?? rights;
            }
        }

        internal UserApis(EncompassRestClient client, string userId)
            : base(client, userId, null)
        {
        }
    }
}