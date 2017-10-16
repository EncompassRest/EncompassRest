using EncompassRest.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
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
            using (var response = await Client.HttpClient.GetAsync($"{ _baseApiPath}/{ContactId}{s_apiPath}/{noteId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetContactNoteAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }
        public Task<List<ContactNote>> GetContactNotesAsync(CancellationToken cancellationToken) => GetContactNotesInternalAsync(cancellationToken, async response =>
        {
            var contactNotes = await response.Content.ReadAsAsync<List<ContactNote>>().ConfigureAwait(false);
            foreach (var note in contactNotes)
            {
                note.Dirty = false;
            }
            return contactNotes;
        });
        public Task<string> GetContactNotesRawAsync(CancellationToken cancellationToken) => GetContactNotesInternalAsync(cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetContactNotesInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_baseApiPath}/{ContactId}{s_apiPath}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetContactNotesAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }
        public Task<string> CreateContactNoteAsync(ContactNote contactNote, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contactNote, nameof(contactNote));

            return CreateContactNoteInternalAsync(JsonStreamContent.Create(contactNote), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(contactNote).ConfigureAwait(false);
                }
                contactNote.Dirty = false;
                return Path.GetFileName(response.Headers.Location.OriginalString);
            });
        }
        public Task<string> CreateContactNoteRawAsync(string contactNote, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactNote, nameof(contactNote));

            return CreateContactNoteInternalAsync(new JsonStringContent(contactNote), queryString, cancellationToken, async response =>
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return string.IsNullOrEmpty(json) ? Path.GetFileName(response.Headers.Location.OriginalString) : json;
            });
        }
        private async Task<string> CreateContactNoteInternalAsync(HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PostAsync($"{_baseApiPath}/{ContactId}{s_apiPath}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateContactNoteAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task UpdateContactNoteAsync(ContactNote contactNote, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contactNote, nameof(contactNote));

            return UpdateContactNoteInternalAsync(contactNote.NoteId, JsonStreamContent.Create(contactNote), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(contactNote).ConfigureAwait(false);
                }
                contactNote.Dirty = false;
                return string.Empty;
            });
        }
        public Task<string> UpdateContactNoteRawAsync(string contactNoteId, string contactNote, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactNoteId, nameof(contactNoteId));
            Preconditions.NotNullOrEmpty(contactNote, nameof(contactNote));

            return UpdateContactNoteInternalAsync(contactNoteId, new JsonStringContent(contactNote), queryString, cancellationToken, response => response.Content.ReadAsStringAsync());
        }
        private async Task<string> UpdateContactNoteInternalAsync(string contactNoteId, HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{_baseApiPath}/{ContactId}{s_apiPath}/{contactNoteId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateContactNoteAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public async Task<bool> DeleteContactNoteAsync(string contactNoteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactNoteId, nameof(contactNoteId));

            using (var response = await Client.HttpClient.DeleteAsync($"{_baseApiPath}/{ContactId}{s_apiPath}/{contactNoteId}", cancellationToken).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }
    }
}
