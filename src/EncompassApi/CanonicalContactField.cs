using System.Runtime.Serialization;

namespace EncompassApi
{
    /// <summary>
    /// CanonicalContactField
    /// </summary>
    public enum CanonicalContactField
    {
        /// <summary>
        /// Contact.Anniversary
        /// </summary>
        Anniversary = 0,
        /// <summary>
        /// Contact.Birthdate
        /// </summary>
        Birthdate = 1,
        /// <summary>
        /// Contact.LastModified
        /// </summary>
        LastModified = 2,
        /// <summary>
        /// Contact.CategoryID
        /// </summary>
        CategoryID = 100,
        /// <summary>
        /// Contact.ContactID
        /// </summary>
        ContactID = 101,
        /// <summary>
        /// Contact.Fees
        /// </summary>
        Fees = 102,
        /// <summary>
        /// Contact.Income
        /// </summary>
        Income = 103,
        /// <summary>
        /// Contact.Married
        /// </summary>
        Married = 104,
        /// <summary>
        /// Contact.NoCall
        /// </summary>
        NoCall = 105,
        /// <summary>
        /// Contact.NoFax
        /// </summary>
        NoFax = 106,
        /// <summary>
        /// Contact.NoSpam
        /// </summary>
        NoSpam = 107,
        /// <summary>
        /// Contact.SpouseContactID
        /// </summary>
        SpouseContactID = 108,
        /// <summary>
        /// Contact.BizAddress1
        /// </summary>
        BizAddress1 = 200,
        /// <summary>
        /// Contact.BizAddress2
        /// </summary>
        BizAddress2 = 201,
        /// <summary>
        /// Contact.BizCity
        /// </summary>
        BizCity = 202,
        /// <summary>
        /// Contact.BizEmail
        /// </summary>
        BizEmail = 203,
        /// <summary>
        /// Contact.BizState
        /// </summary>
        BizState = 204,
        /// <summary>
        /// Contact.BizWebUrl
        /// </summary>
        BizWebUrl = 205,
        /// <summary>
        /// Contact.BizZip
        /// </summary>
        BizZip = 206,
        /// <summary>
        /// Contact.Comment
        /// </summary>
        Comment = 207,
        /// <summary>
        /// Contact.Company.Name
        /// </summary>
        [EnumMember(Value = "Company.Name")]
        CompanyName = 208,
        /// <summary>
        /// Contact.ContactType
        /// </summary>
        ContactType = 209,
        /// <summary>
        /// Contact.CustField1
        /// </summary>
        CustField1 = 210,
        /// <summary>
        /// Contact.CustField2
        /// </summary>
        CustField2 = 211,
        /// <summary>
        /// Contact.CustField3
        /// </summary>
        CustField3 = 212,
        /// <summary>
        /// Contact.CustField4
        /// </summary>
        CustField4 = 213,
        /// <summary>
        /// Contact.EmployerName
        /// </summary>
        EmployerName = 214,
        /// <summary>
        /// Contact.FaxNumber
        /// </summary>
        FaxNumber = 215,
        /// <summary>
        /// Contact.FirstName
        /// </summary>
        FirstName = 216,
        /// <summary>
        /// Contact.HomeAddress1
        /// </summary>
        HomeAddress1 = 217,
        /// <summary>
        /// Contact.HomeAddress2
        /// </summary>
        HomeAddress2 = 218,
        /// <summary>
        /// Contact.HomeCity
        /// </summary>
        HomeCity = 219,
        /// <summary>
        /// Contact.HomePhone
        /// </summary>
        HomePhone = 220,
        /// <summary>
        /// Contact.HomeState
        /// </summary>
        HomeState = 221,
        /// <summary>
        /// Contact.HomeZip
        /// </summary>
        HomeZip = 222,
        /// <summary>
        /// Contact.JobTitle
        /// </summary>
        JobTitle = 223,
        /// <summary>
        /// Contact.LastName
        /// </summary>
        LastName = 224,
        /// <summary>
        /// Contact.LicenseNumber
        /// </summary>
        LicenseNumber = 225,
        /// <summary>
        /// Contact.MobilePhone
        /// </summary>
        MobilePhone = 226,
        /// <summary>
        /// Contact.OwnerID
        /// </summary>
        OwnerID = 227,
        /// <summary>
        /// Contact.PersonalEmail
        /// </summary>
        PersonalEmail = 228,
        /// <summary>
        /// Contact.PrimaryEmail
        /// </summary>
        PrimaryEmail = 229,
        /// <summary>
        /// Contact.PrimaryPhone
        /// </summary>
        PrimaryPhone = 230,
        /// <summary>
        /// Contact.Referral
        /// </summary>
        Referral = 231,
        /// <summary>
        /// Contact.SpouseName
        /// </summary>
        SpouseName = 232,
        /// <summary>
        /// Contact.SSN
        /// </summary>
        SSN = 233,
        /// <summary>
        /// Contact.Status
        /// </summary>
        Status = 234,
        /// <summary>
        /// Contact.WorkPhone
        /// </summary>
        WorkPhone = 235
    }
}