namespace EncompassRest.Services
{
    public class ServiceCredentials : SerializableObject
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}