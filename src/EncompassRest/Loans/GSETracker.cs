using System;

namespace EncompassRest.Loans
{
    /// <summary>
    /// GSETracker
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class GSETracker : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _altId;
        private DirtyValue<string> _dUFindingsMessageID;
        private DirtyValue<string> _dUFindingsMessageText;
        private DirtyValue<DateTime?> _gSECloseByDate;
        private DirtyValue<string> _id;

        /// <summary>
        /// GSE Rep and Warrant Tracker - Identifier [TQLGSENN99]
        /// </summary>
        public string AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message ID [TQLGSENN01]
        /// </summary>
        public string DUFindingsMessageID { get => _dUFindingsMessageID; set => SetField(ref _dUFindingsMessageID, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message Text [TQLGSENN02]
        /// </summary>
        public string DUFindingsMessageText { get => _dUFindingsMessageText; set => SetField(ref _dUFindingsMessageText, value); }

        /// <summary>
        /// GSE Rep and Warrant Tracker - GSE Close By Date [TQLGSENN03]
        /// </summary>
        public DateTime? GSECloseByDate { get => _gSECloseByDate; set => SetField(ref _gSECloseByDate, value); }

        /// <summary>
        /// GSETracker Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
    }
}