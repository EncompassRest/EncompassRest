#r "../bin/EncompassRest.dll"
#r "../../EncompassRest.EntityGenerator/bin/EncompassRest.EntityGenerator.dll"

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
        await EntityGenerator.GenerateClassFilesFromSchemaAsync(client, Path.GetDirectoryName(ScriptFilePath), "EncompassRest.Loans");
    }
}).Wait();