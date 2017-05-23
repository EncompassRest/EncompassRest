using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LogComment
    {
        public string AddedBy { get; set; }
        public string AddedByName { get; set; }
        public string Comments { get; set; }
        public JsonNullable<DateTime?> Date { get; set; }
        public int? ForRoleId { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsInternal { get; set; }
        public string ReviewedBy { get; set; }
        public JsonNullable<DateTime?> ReviewedDate { get; set; }
    }
}