using FluentAssertions;
using FluentAssertions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EncompassApi.xUnitTests.Extensions
{
    public static class ObjectAssertionsExtensions
    {
        public static AndConstraint<ObjectAssertions> BeEqual<TAssertion>(this ObjectAssertions assert,
    TAssertion target, TAssertion source, Func<TAssertion, TAssertion, bool> isEqualFunc)
        {

            Assert.True(isEqualFunc(source, target));
            return assert.NotBeNull(because: "it must not be null");
        }

        /// <summary>
        /// <para>Asserts that the objects is assignable to Tassertions.</para>
        /// <para>Validates that the TAssertion has the specific properties</para>
        /// </summary>
        /// <typeparam name="TAssertions"></typeparam>
        /// <param name="source"></param>
        /// <param name="properties">Properties to validate</param>
        /// <returns></returns>


        public static AndConstraint<ObjectAssertions> BeOfObject<TAssertion>(this ObjectAssertions assert,
            TAssertion source, params string[] properties)
        {
            foreach (var property in properties)
            {
                var p = source.GetType().GetProperty(property);
                Assert.True(p != null, $"property {p.Name} cannot be found in type {source.GetType().Name}");
                Assert.True(p.GetValue(source) != null, $"property {p.Name} has no value");
            }

            return assert.NotBeNull(because: "object type {0} it must not be null", source.GetType().Name);
        }


    }
}
