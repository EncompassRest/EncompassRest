
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class FeeVarianceOther
{
public DateTime? chargesThatCannotDecreaseInitialLE1 { get; set; }
public DateTime? chargesThatCannotDecreaseLE1 { get; set; }
public DateTime? chargesThatCannotDecreaseCD1 { get; set; }
public DateTime? chargesThatCannotIncreaseInitialLE1 { get; set; }
public DateTime? chargesThatCannotIncreaseLE1 { get; set; }
public DateTime? chargesThatCannotIncreaseCD1 { get; set; }
public DateTime? chargesCannotIncrease10InitialLE1 { get; set; }
public DateTime? chargesCannotIncrease10LE1 { get; set; }
public DateTime? chargesCannotIncrease10CD1 { get; set; }
public DateTime? chargesThatCanChangeInitialLE1 { get; set; }
public DateTime? chargesThatCanChangeLE1 { get; set; }
public DateTime? chargesThatCanChangeCD1 { get; set; }
public DateTime? goodFaithAmountInitialLE1 { get; set; }
public decimal? requiredCureAmount { get; set; }
public decimal? appliedCureAmount { get; set; }
public string lEInitialGuid { get; set; }
public string lELatestGuid { get; set; }
public string cDInitialGuid { get; set; }
public string cDLatestGuid { get; set; }
public string cannotDecreaseLEBaselineGuid { get; set; }
public string cannotDecreaseCDBaselineGuid { get; set; }
public string cannotIncreaseLEBaselineGuid { get; set; }
public string cannotIncreaseCDBaselineGuid { get; set; }
public string cannotIncrease10LEBaselineGuid { get; set; }
public string cannotIncrease10CDBaselineGuid { get; set; }
public bool? lEBaselineUsedCannotDecrease { get; set; }
public bool? lEBaselineUsedCannotIncrease { get; set; }
public bool? lEBaselineUsedCannotIncrease10 { get; set; }
public string cDPostConGuid { get; set; }
public string safeHarborGuid { get; set; }
public string lEInitialDTGuid { get; set; }
public string cDRecentAppliedCure { get; set; }
public string disclosureLogGUIDForECD { get; set; }
public string sSPLGuid { get; set; }
public string id { get; set; }

    }
}