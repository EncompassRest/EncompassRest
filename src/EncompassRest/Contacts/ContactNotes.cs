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
        
        internal ContactNotes(EncompassRestClient client, string baseApiPath, string contactId)
        {
            Client = client;
            ContactId = contactId;
            _baseApiPath = baseApiPath;
        }

        public Task<ContactNote> GetNoteAsync(string noteId) => GetNoteAsync(noteId, CancellationToken.None);
        public Task<ContactNote> GetNoteAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return (GetNoteInternalAsync(noteId, cancellationToken, async resposne =>
            {
                var contactNote = await resposne.Content.ReadAsAsync<ContactNote>().ConfigureAwait(false);
                contactNote.Dirty = false;
                return contactNote;
            }));
        }
        public Task<string> GetNoteRawAsync(string noteId) => GetNoteRawAsync(noteId, CancellationToken.None);
        public Task<string> GetNoteRawAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return GetNoteInternalAsync(noteId, cancellationToken, response => response.Content.ReadAsStringAsync());
        }
        private async Task<T> GetNoteInternalAsync<T>(string noteId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{ _baseApiPath}/{ContactId}{s_apiPath}/{noteId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetNoteAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<ContactNote>> GetNotesAsync() => GetNotesAsync(CancellationToken.None);
        public Task<List<ContactNote>> GetNotesAsync(CancellationToken cancellationToken) => GetNotesInternalAsync(cancellationToken, async response =>
        {
            var contactNotes = await response.Content.ReadAsAsync<List<ContactNote>>().ConfigureAwait(false);
            foreach (var note in contactNotes)
            {
                note.Dirty = false;
            }
            return contactNotes;
        });
        public Task<string> GetNotesRawAsync() => GetNotesRawAsync(CancellationToken.None);
        public Task<string> GetNotesRawAsync(CancellationToken cancellationToken) => GetNotesInternalAsync(cancellationToken, response => response.Content.ReadAsStringAsync());
        private async Task<T> GetNotesInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_baseApiPath}/{ContactId}{s_apiPath}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetNotesAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateNoteAsync(ContactNote contactNote) => CreateNoteAsync(contactNote, false, CancellationToken.None);
        public Task<string> CreateNoteAsync(ContactNote contactNote, CancellationToken cancellationToken) => CreateNoteAsync(contactNote, false, cancellationToken);
        public Task<string> CreateNoteAsync(ContactNote contactNote, bool populate) => CreateNoteAsync(contactNote, populate, CancellationToken.None);
        public Task<string> CreateNoteAsync(ContactNote contactNote, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contactNote, nameof(contactNote));

            return CreateNoteInternalAsync(JsonStreamContent.Create(contactNote), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(contactNote).ConfigureAwait(false);
                }
                contactNote.Dirty = false;
                return Path.GetFileName(response.Headers.Location.OriginalString);
            });
        }
        public Task<string> CreateNoteRawAsync(string contactNote) => CreateNoteRawAsync(contactNote, null, CancellationToken.None);
        public Task<string> CreateNoteRawAsync(string contactNote, CancellationToken cancellationToken) => CreateNoteRawAsync(contactNote, null, cancellationToken);
        public Task<string> CreateNoteRawAsync(string contactNote, string queryString) => CreateNoteRawAsync(contactNote, queryString, CancellationToken.None);
        public Task<string> CreateNoteRawAsync(string contactNote, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactNote, nameof(contactNote));

            return CreateNoteInternalAsync(new JsonStringContent(contactNote), queryString, cancellationToken, async response =>
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return string.IsNullOrEmpty(json) ? Path.GetFileName(response.Headers.Location.OriginalString) : json;
            });
        }
        private async Task<string> CreateNoteInternalAsync(HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PostAsync($"{_baseApiPath}/{ContactId}{s_apiPath}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateNoteAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task UpdateNoteAsync(ContactNote contactNote) => UpdateNoteAsync(contactNote, false, CancellationToken.None);
        public Task UpdateNoteAsync(ContactNote contactNote, CancellationToken cancellationToken) => UpdateNoteAsync(contactNote, false, cancellationToken);
        public Task UpdateNoteAsync(ContactNote contactNote, bool populate) => UpdateNoteAsync(contactNote, populate, CancellationToken.None);
        public Task UpdateNoteAsync(ContactNote contactNote, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(contactNote, nameof(contactNote));

            return UpdateNoteInternalAsync(contactNote.NoteId, JsonStreamContent.Create(contactNote), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(contactNote).ConfigureAwait(false);
                }
                contactNote.Dirty = false;
                return string.Empty;
            });
        }
        public Task<string> UpdateNoteRawAsync(string contactNoteId, string contactNote) => UpdateNoteRawAsync(contactNoteId, contactNote, null, CancellationToken.None);
        public Task<string> UpdateNoteRawAsync(string contactNoteId, string contactNote, CancellationToken cancellationToken) => UpdateNoteRawAsync(contactNoteId, contactNote, null, cancellationToken);
        public Task<string> UpdateNoteRawAsync(string contactNoteId, string contactNote, string queryString) => UpdateNoteRawAsync(contactNoteId, contactNote, queryString, CancellationToken.None);
        public Task<string> UpdateNoteRawAsync(string contactNoteId, string contactNote, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactNoteId, nameof(contactNoteId));
            Preconditions.NotNullOrEmpty(contactNote, nameof(contactNote));

            return UpdateNoteInternalAsync(contactNoteId, new JsonStringContent(contactNote), queryString, cancellationToken, response => response.Content.ReadAsStringAsync());
        }
        private async Task<string> UpdateNoteInternalAsync(string contactNoteId, HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{_baseApiPath}/{ContactId}{s_apiPath}/{contactNoteId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateNoteAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<bool> DeleteNoteAsync(string contactId) => DeleteNoteAsync(contactId, CancellationToken.None);
        public async Task<bool> DeleteNoteAsync(string contactNoteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(contactNoteId, nameof(contactNoteId));

            using (var response = await Client.HttpClient.DeleteAsync($"{_baseApiPath}/{ContactId}{s_apiPath}/{contactNoteId}", cancellationToken).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }
    }
}
