using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// DocEngine
/// </summary>
public enum DocEngine
{
    /// <summary>
    /// Old ODI Encompass Docs
    /// </summary>
    [Description("Old ODI Encompass Docs")]
    [EnumMember(Value = "Old_ODI_Encompass_Docs")]
    OldODIEncompassDocs = 0,
    /// <summary>
    /// New Encompass Docs Solution
    /// </summary>
    [Description("New Encompass Docs Solution")]
    [EnumMember(Value = "New_Encompass_Docs_Solution")]
    NewEncompassDocsSolution = 1
}