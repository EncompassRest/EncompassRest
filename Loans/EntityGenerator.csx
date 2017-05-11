#r "../bin/EncompassRest.dll"

using System.IO;
using System.Threading.Tasks;
using EncompassRest;

// Do not commit values in these variables to source control
string clientId = "";
string clientSecret = "";
string instanceId = "";
string userId = "";
string password = "";

Task.Run(async () =>
{
    using (var client = await EncompassRestClient.CreateFromUserCredentialsAsync(clientId, clientSecret, instanceId, userId, password))
    {
        await client.Schemas.GenerateClassFilesFromSchemaAsync(Path.GetDirectoryName(ScriptFilePath), "EncompassRest.Loans");
    }
}).Wait();