namespace EncompassRest.Contacts
{
    public enum BusinessContactCategory
    {
        Appraiser = 0,
        Attourney = 1,
        Credit_Company = 2,
        Doc_Signing = 3,
        Escrow_Company = 4,
        Flood_Insurance = 5,
        Hazard_Insurance = 6,
        Lender = 7,
        Mortgage_Insurance = 8,
        Real_Estate_Agent = 9,
        Servicing = 10,
        Title_Insurance = 11,
        Underwriter = 12,
        Surveyor = 13,
        No_Category = 14,
        Organization = 15,
        Verification = 16,
        Investor = 17,
        Warehouse_Bank = 18,
        Builder = 19,
        Dealer = 20,
        TradeAssignee = 21
    }

    public sealed class BusinessContact : Contact
    {
        public BusinessContact() :base()
        {
            PersonalContactLicense = new BusinessContactLicense();
            BusinessContactLicense = new BusinessContactLicense();
        }
        public BusinessContactCategory CategoryId { get; set; }
        public string CompanyName { get; set; }
        public BusinessContactLicense PersonalContactLicense { get; set; }
        public BusinessContactLicense BusinessContactLicense { get; set; }
        public bool? NoSpam { get; set; }
        public string Fees { get; set; }
    }
}
