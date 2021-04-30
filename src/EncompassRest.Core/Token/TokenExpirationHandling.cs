namespace EncompassRest.Token
{
    /// <summary>
    /// TokenExpirationHandling
    /// </summary>
    public enum TokenExpirationHandling
    {
        /// <summary>
        /// Default, when the token expires the client will cease to work with the Apis and instead will result in 401 Unauthorized errors.
        /// </summary>
        Default = 0,
        /// <summary>
        /// RetrieveNewToken, when getting a 401 Unauthorized error from using the Apis the supplied tokenInitializer will be invoked to retrieve a new token.
        /// </summary>
        RetrieveNewToken = 1
    }
}