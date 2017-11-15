using System.Runtime.Serialization;

namespace EncompassRest.Schema
{
    public enum LoanFieldFormat
    {
        STRING = 101,
        YN = 102,
        X = 103,
        [EnumMember(Value = "zipcode")]
        ZIPCODE = 104,
        [EnumMember(Value = "state")]
        STATE = 105,
        [EnumMember(Value = "phone")]
        PHONE = 106,
        [EnumMember(Value = "ssn")]
        SSN = 107,
        TRACKING = 108,
        INTEGER = 201,
        [EnumMember(Value = "decimal_1")]
        DECIMAL_1 = 202,
        [EnumMember(Value = "decimal_2")]
        DECIMAL_2 = 203,
        [EnumMember(Value = "decimal_3")]
        DECIMAL_3 = 204,
        [EnumMember(Value = "decimal_4")]
        DECIMAL_4 = 205,
        [EnumMember(Value = "decimal_5")]
        DECIMAL_5 = 206,
        [EnumMember(Value = "decimal_6")]
        DECIMAL_6 = 207,
        [EnumMember(Value = "decimal_7")]
        DECIMAL_7 = 209,
        [EnumMember(Value = "decimal_10")]
        DECIMAL_10 = 211,
        DECIMAL = 210,
        DATE = 301,
        TIME = 302,
        MONTHDAY = 303,
        DATETIME = 304,
        DROPDOWN = 999,
        DROPDOWNLIST = 998,
        AUDIT = 1001,
        NONE = 0
    }
}