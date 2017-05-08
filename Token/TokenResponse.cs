using System;
using System.Runtime.Serialization;

namespace EncompassRest
{
    // make sure to add the reference the System.Runtime.Serialization.dll file.
    [DataContract]
    public class TokenResponse
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }
        [DataMember(Name = "token_type")]
        public string TokenType { get; set; }
    }

    [DataContract]
    public class TokenValidateResponse
    {
        [DataMember(Name = "active")]
        public bool IsActive { get; set; }
        [DataMember(Name = "scope")]
        public string Scope { get; set; }
        [DataMember(Name = "client_id")]
        public string ClientId { get; set; }
        [DataMember(Name ="username")]
        public string Username { get; set; }
        [DataMember(Name ="token_type")]
        public string TokenType { get; set; }
        [DataMember(Name ="exp")]
        public int Expires { get; set; }
        [DataMember(Name ="sub")]
        public string Sub { get; set; }
        [DataMember (Name = "encompass_instance_id")]
        public string InstanceId { get; set; }
        [DataMember(Name ="user_name")]
        public string UserName { get; set; }
        [DataMember(Name ="user_key")]
        public string UserKey { get; set; }
        [DataMember(Name ="encompass_user")]
        public string EncompassUser { get; set; }
        [DataMember(Name ="identity_type")]
        public string IdentityType { get; set; }
        [DataMember (Name ="encompass_client_id")]
        public string EncomapssClientId { get; set; }
        [DataMember(Name ="realm_name")]
        public string RealmName { get; set; }

        public DateTime GetExpirationDate()
        {
            var expires = DateTime.SpecifyKind(new DateTime(1970, 01, 01), DateTimeKind.Utc);

            return DateTime.SpecifyKind(expires.AddSeconds(Expires), DateTimeKind.Local);
        }
    }
}
