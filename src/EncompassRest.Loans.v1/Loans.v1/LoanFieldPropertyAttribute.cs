using System;
using System.Collections.Generic;
using EncompassRest.Schema;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.v1
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    internal sealed class LoanFieldPropertyAttribute : Attribute
    {
        private Dictionary<string, string>? _options;
        private List<string>? _missingOptions;
        internal LoanFieldFormat? _format;

        public LoanFieldFormat Format { get => _format!.Value; set => _format = value; }

        public bool ReadOnly { get; set; }

        public string? OptionsJson { get; set; }

        public string? MissingOptionsJson { get; set; }

        internal Dictionary<string, string>? Options
        {
            get
            {
                var options = _options;
                if (options == null && !string.IsNullOrEmpty(OptionsJson))
                {
                    options = JsonHelper.FromJson<Dictionary<string, string>>(OptionsJson!);
                    _options = options;
                }
                return options;
            }
        }

        internal List<string>? MissingOptions
        {
            get
            {
                var missingOptions = _missingOptions;
                if (missingOptions == null && !string.IsNullOrEmpty(MissingOptionsJson))
                {
                    missingOptions = JsonHelper.FromJson<List<string>>(MissingOptionsJson!);
                    _missingOptions = missingOptions;
                }
                return missingOptions;
            }
        }
    }
}