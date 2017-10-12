using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Contacts
{
    public sealed class ContactNote
    {
        public string NoteId { get; set; }
        public string Subject { get; set; }
        [JsonIgnore]
        public DateTime? Timestamp { get; set; }
        public string Details { get; set; }
    }
}
