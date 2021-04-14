using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.xUnitTests
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class TestAttribute : Attribute
    {
        public string Parameter
        {
            get;
            set;
        }
        public TestAttribute()
        {


        }
    }
}
