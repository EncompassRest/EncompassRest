using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    public sealed class ContactNotes
    {
        private const string s_apiPath = "/notes";
        private string _baseApiPath;
        public EncompassRestClient Client { get; }

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

            return GetNoteInternalAsync(noteId, cancellationToken, async response =>
            {
                var note = await response.Content.ReadAsAsync<ContactNote>().ConfigureAwait(false);
                note.NoteId = noteId; //TODO: Remove this when EM corrects bug
                note.Dirty = false;
                return note;
            });
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
                    throw await EncompassRestException.CreateAsync(nameof(GetNoteAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<ContactNote>> GetNotesAsync() => GetNotesAsync(CancellationToken.None);

        public Task<List<ContactNote>> GetNotesAsync(CancellationToken cancellationToken) => GetNotesInternalAsync(cancellationToken, async response =>
        {
            var notes = await response.Content.ReadAsAsync<List<ContactNote>>().ConfigureAwait(false);
            foreach (var note in notes)
            {
                note.Dirty = false;
            }
            return notes;
        });

        public Task<string> GetNotesRawAsync() => GetNotesRawAsync(CancellationToken.None);

        public Task<string> GetNotesRawAsync(CancellationToken cancellationToken) => GetNotesInternalAsync(cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetNotesInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_baseApiPath}/{ContactId}{s_apiPath}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(GetNotesAsync), response).ConfigureAwait(false);
                }
                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateNoteAsync(ContactNote note) => CreateNoteAsync(note, false, CancellationToken.None);

        public Task<string> CreateNoteAsync(ContactNote note, CancellationToken cancellationToken) => CreateNoteAsync(note, false, cancellationToken);

        private Task<string> CreateNoteAsync(ContactNote note, bool populate) => CreateNoteAsync(note, populate, CancellationToken.None);

        private Task<string> CreateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(note, nameof(note));

            return CreateNoteInternalAsync(JsonStreamContent.Create(note), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                var noteId = Path.GetFileName(response.Headers.Location.OriginalString);
                note.NoteId = noteId;
                if (populate)
                {
                    await response.Content.PopulateAsync(note).ConfigureAwait(false);
                }
                note.Dirty = false;
                return noteId;
            });
        }

        public Task<string> CreateNoteRawAsync(string note) => CreateNoteRawAsync(note, null, CancellationToken.None);

        public Task<string> CreateNoteRawAsync(string note, CancellationToken cancellationToken) => CreateNoteRawAsync(note, null, cancellationToken);

        private Task<string> CreateNoteRawAsync(string note, string queryString) => CreateNoteRawAsync(note, queryString, CancellationToken.None);

        private Task<string> CreateNoteRawAsync(string note, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return CreateNoteInternalAsync(new JsonStringContent(note), queryString, cancellationToken, async response =>
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
                    throw await EncompassRestException.CreateAsync(nameof(CreateNoteAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task UpdateNoteAsync(ContactNote note) => UpdateNoteAsync(note, false, CancellationToken.None);

        public Task UpdateNoteAsync(ContactNote note, CancellationToken cancellationToken) => UpdateNoteAsync(note, false, cancellationToken);

        private Task UpdateNoteAsync(ContactNote note, bool populate) => UpdateNoteAsync(note, populate, CancellationToken.None);

        private Task UpdateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(note, nameof(note));

            return UpdateNoteInternalAsync(note.NoteId, JsonStreamContent.Create(note), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(note).ConfigureAwait(false);
                }
                note.Dirty = false;
                return string.Empty;
            });
        }

        public Task<string> UpdateNoteRawAsync(string noteId, string note) => UpdateNoteRawAsync(noteId, note, null, CancellationToken.None);

        public Task<string> UpdateNoteRawAsync(string noteId, string note, CancellationToken cancellationToken) => UpdateNoteRawAsync(noteId, note, null, cancellationToken);

        private Task<string> UpdateNoteRawAsync(string noteId, string note, string queryString) => UpdateNoteRawAsync(noteId, note, queryString, CancellationToken.None);

        private Task<string> UpdateNoteRawAsync(string noteId, string note, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return UpdateNoteInternalAsync(noteId, new JsonStringContent(note), queryString, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<string> UpdateNoteInternalAsync(string noteId, HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{_baseApiPath}/{ContactId}{s_apiPath}/{noteId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await EncompassRestException.CreateAsync(nameof(UpdateNoteAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<bool> DeleteNoteAsync(string noteId) => DeleteNoteAsync(noteId, CancellationToken.None);

        public async Task<bool> DeleteNoteAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            using (var response = await Client.HttpClient.DeleteAsync($"{_baseApiPath}/{ContactId}{s_apiPath}/{noteId}", cancellationToken).ConfigureAwait(false))
            {
                return response.IsSuccessStatusCode;
            }
        }
    }
}
