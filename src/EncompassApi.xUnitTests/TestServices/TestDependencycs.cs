using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.xUnitTests.TestServices
{
    public interface ITestDependencycs
    {
        int Value { get; set; }

        int TestMethod(int count);
    }

    public class TestDependency : ITestDependencycs
    {
        public int Value { get; set; }

        public int TestMethod(int count)
        {
            return count;
        }
    }
}
