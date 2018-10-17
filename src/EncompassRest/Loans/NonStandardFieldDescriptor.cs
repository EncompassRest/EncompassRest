using System.Collections.Generic;
using System.Collections.ObjectModel;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    internal sealed class NonStandardFieldDescriptor : FieldDescriptor
    {
        public override ReadOnlyCollection<FieldOption> Options { get; }

        public override LoanFieldFormat? Format { get; }

        public override LoanFieldValueType ValueType
        {
            get
            {
                var format = Format.GetValueOrDefault();
                var formatAsInt = (int)format;
                if (formatAsInt >= 300 && formatAsInt < 400)
                {
                    return LoanFieldValueType.DateTime;
                }
                if (formatAsInt >= 200 && formatAsInt < 300)
                {
                    if (format == LoanFieldFormat.INTEGER)
                    {
                        return LoanFieldValueType.Int32;
                    }
                    return LoanFieldValueType.Decimal;
                }
                if (format == LoanFieldFormat.YN)
                {
                    return LoanFieldValueType.Boolean;
                }
                return LoanFieldValueType.String;
            }
        }

        public override bool ReadOnly { get; }

        internal NonStandardFieldDescriptor(string fieldId, ModelPath modelPath, string modelPathString, string description, LoanFieldFormat? format, IList<FieldOption> options, bool readOnly, bool multiInstance = false)
            : base(fieldId, modelPath, modelPathString, description, multiInstance: multiInstance)
        {
            Format = format;
            if (options == null)
            {
                options = new List<FieldOption>();
                if (format == LoanFieldFormat.YN)
                {
                    options.Add(new FieldOption("Y"));
                    options.Add(new FieldOption("N"));
                }
            }
            Options = new ReadOnlyCollection<FieldOption>(options);
            ReadOnly = readOnly;
        }
    }
}