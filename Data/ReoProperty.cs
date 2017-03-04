
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class ReoProperty
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public decimal? participationPercentage { get; set; }
        public decimal? lienInstallmentAmount { get; set; }
        public decimal? lienUpbAmount { get; set; }
        public string gsePropertyType { get; set; }
        public decimal? marketValueAmount { get; set; }
        public decimal? rentalIncomeGrossAmount { get; set; }
        public string maintenanceExpenseAmount { get; set; }
        public DateTime? acquiredDate { get; set; }
        public int? purchasePrice { get; set; }
        public string dispositionStatusType { get; set; }
        public string reoComments { get; set; }
        public decimal? percentageofRental { get; set; }
        public bool? subjectIndicator { get; set; }
        public decimal? rentalIncomeNetAmount { get; set; }
        public bool? printAttachIndicator { get; set; }
        public string title { get; set; }
        public bool? printUserNameIndicator { get; set; }
        public string propertyUsageType { get; set; }
        public string reoId { get; set; }
        public string titlePhone { get; set; }
        public string titleFax { get; set; }
        public bool? noLinkToDocTrackIndicator { get; set; }
        public DateTime? requestDate { get; set; }
        public string id { get; set; }
        public bool? entityDeleted { get; set; }
        public bool? isEmpty { get; set; }
        public int? reoPropertyIndex { get; set; }

    }
}