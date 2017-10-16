using EncompassRest.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.Contacts
{
    public sealed class ContactNotes
    {
        private const string s_apiPath = "/notes";
        private string _baseApiPath;
        public EncompassRestClient Client { get; private set; }

        public string ContactId { get; }
        
        public ContactNotes(EncompassRestClient client, string baseApiPath, string contactId)
        {
            Client = client;
            ContactId = contactId;
            _baseApiPath = baseApiPath;
        }

        public Task<ContactNote> GetContactNoteAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return (GetContactNoteInternalAsync(noteId, cancellationToken, async resposne =>
            {
                var contactNote = await resposne.Content.ReadAsAsync<ContactNote>().ConfigureAwait(false);
                contactNote.Dirty = false;
                return contactNote;
            }));
        }
        public Task<string> GetContactNoteRawAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return GetContactNoteInternalAsync(noteId, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetContactNoteInternalAsync<T>(string noteId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{ _baseApiPath}{ContactId}{s_apiPath}/{noteId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetContactNoteAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }
    }
}
