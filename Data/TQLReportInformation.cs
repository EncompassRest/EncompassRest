
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class TQLReportInformation
{
public string userID { get; set; }
public DateTime? orderDate { get; set; }
public DateTime? completedDate { get; set; }
public string orderStatus { get; set; }
public string orderNumber { get; set; }
public string investor { get; set; }
public string productsOrdered { get; set; }
public string transcriptType { get; set; }
public string reportYear1 { get; set; }
public string borrowerID1 { get; set; }
public decimal? totalIncome1 { get; set; }
public decimal? percentVariance1 { get; set; }
public string reportYear2 { get; set; }
public string borrowerID2 { get; set; }
public decimal? totalIncome2 { get; set; }
public decimal? percentVariance2 { get; set; }
public string reportYear3 { get; set; }
public string borrowerID3 { get; set; }
public decimal? totalIncome3 { get; set; }
public decimal? percentVariance3 { get; set; }
public string reportYear4 { get; set; }
public string borrowerID4 { get; set; }
public decimal? totalIncome4 { get; set; }
public decimal? percentVariance4 { get; set; }
public string altId { get; set; }
public string id { get; set; }

    }
}