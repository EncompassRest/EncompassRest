using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public sealed class Preferences
    {
        public bool ImportLiabilities { get; set; }
        public bool ExcludeZeroBalances { get; set; }

    }
}
