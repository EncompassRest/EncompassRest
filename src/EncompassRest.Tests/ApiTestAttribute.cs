using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    public sealed class ApiTestAttribute : TestCategoryBaseAttribute
    {
        private static readonly List<string> s_categories = new List<string> { "SkipWhenLiveUnitTesting" };

        public override IList<string> TestCategories => s_categories;
    }
}