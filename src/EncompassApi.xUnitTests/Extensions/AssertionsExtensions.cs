using FluentAssertions;
using FluentAssertions.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Reflection;
using FluentAssertions.Primitives;
using Newtonsoft.Json.Linq;

namespace EncompassApi.xUnitTests.Extensions
{
    public static class AssertionsExtensions
    {

        /// <summary>
        /// <para>Compares target and source base on an inputed logic</para>
        /// </summary>
        /// <typeparam name="TAssertions"></typeparam>
        /// <param name="isEqualFunc">Comparison logic</param>
        /// <returns></returns>
        public static AndConstraint<GenericCollectionAssertions<TAssertions>> BeEqual<TAssertions>(this GenericCollectionAssertions<TAssertions> assert,
             IEnumerable<TAssertions> target, IEnumerable<TAssertions> source, Func<TAssertions, TAssertions, bool> isEqualFunc)
        {
            var srcAry = source.ToArray();
            var trgtAry = target.ToArray();

            for (int i = 0; i < target.Count(); i++)
            {
                Assert.True(isEqualFunc(srcAry[i], trgtAry[i]));
            }

            return assert.NotBeEmpty();
        }

        /// <summary>
        /// <para>Compares target and source base on an inputed logic</para>
        /// </summary>
        /// <typeparam name="TAssertion"></typeparam>
        /// <param name="isEqualFunc">Comparison logic</param>
        /// <returns></returns>
        public static AndConstraint<StringAssertions> BeEqual<TAssertion>(this StringAssertions assert,
             IEnumerable<TAssertion> target, string source, Func<TAssertion, TAssertion, bool> isEqualFunc)
        {
            var srcAry = Newtonsoft.Json.JsonConvert.DeserializeObject<TAssertion[]>(source);
            var trgtAry = target.ToArray();

            for (int i = 0; i < target.Count(); i++)
            {
                Assert.True(isEqualFunc(srcAry[i], trgtAry[i]));
            }

            return assert.NotBeEmpty(because: "it must not be an emoty string");

        }

        public static AndConstraint<StringAssertions> BeEqual<TAssertion>(this StringAssertions assert,
         TAssertion target, string source, Func<TAssertion, TAssertion, bool> isEqualFunc)
        {
            source.Should().NotBeNull(because: "Source cannot be null!").And.NotBeEmpty(because: "Source cannot be empty!");
            var srcObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TAssertion>(source);
            Assert.True(isEqualFunc(target, srcObj));
            return assert.NotBeEmpty(because: "it must not be an emoty string");
        }

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
        public static AndConstraint<StringAssertions> BeOfObjectArray<TAssertion>(this StringAssertions assert, 
            string source, params string[] properties)
        {
            var srcAry = Newtonsoft.Json.JsonConvert.DeserializeObject<TAssertion[]>(source);
            foreach (var property in properties)
            {
                var p = srcAry[0].GetType().GetProperty(property);
                Assert.True(p != null);
                Assert.True(p.GetValue(srcAry[0]) != null);
            }

            return assert.NotBeEmpty(because: "it must not be an emoty string");
        }

        public static AndConstraint<ObjectAssertions> BeOfObject<TAssertion>(this ObjectAssertions assert,
            TAssertion source, params string[] properties)
        {
            foreach (var property in properties)
            {
                var p = source.GetType().GetProperty(property);
                Assert.True(p != null);
                Assert.True(p.GetValue(source) != null);
            }

            return assert.NotBeNull(because: "it must not be null");
        }

        public static AndConstraint<StringAssertions> BeOfObject<TAssertion>(this StringAssertions assert,
            string source, params string[] properties)
        {
            var src = Newtonsoft.Json.JsonConvert.DeserializeObject<TAssertion>(source);
            foreach (var property in properties)
            {
                var p = src.GetType().GetProperty(property);
                Assert.True(p != null);
                Assert.True(p.GetValue(src) != null);
            }

            return assert.NotBeNull(because: "it must not be null");
        }

        public static IEnumerable<TObject> BeOfType<TAssertion, TObject>(this GenericCollectionAssertions<TAssertion> assert, params JObject[] payloads)
        {
            // THIS COULD BE REFINED MORE
            // ....
            var list = new List<TObject>();
            foreach (var item in payloads)
            {
                Assert.IsType<TObject>(item.ToObject<TObject>());
                list.Add(item.ToObject<TObject>());
            }
            assert.Should().NotBeNull(because: "payloads must not be null");
            return list;
        }

       

    }
}
