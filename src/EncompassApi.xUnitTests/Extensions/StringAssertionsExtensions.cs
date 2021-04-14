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
    public static class StringAssertionsExtensions
    {
        public static AndConstraint<StringAssertions> BeOfObjectArray<TAssertion>(this StringAssertions assert,
           string source, params string[] properties)
        {
            return assert.BeOfObjectArray<TAssertion>(source, properties.Length > 0 ? properties.ToArray() : Array.Empty<string>(), because: "it is an emoty string");
        }

        public static AndConstraint<StringAssertions> BeOfObjectArray<TAssertion>(this StringAssertions assert,
            string source, string[] properties, string because, params object[] becauseArgs)
        {
            var srcAry = Newtonsoft.Json.JsonConvert.DeserializeObject<TAssertion[]>(source);
            foreach (var property in properties)
            {
                var p = srcAry[0].GetType().GetProperty(property);
                Assert.True(p != null);
                Assert.True(p.GetValue(srcAry[0]) != null);
            }

            return assert.NotBeEmpty(because: because, becauseArgs: becauseArgs);
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
         TAssertion target, string source, Func<TAssertion, TAssertion, bool> isEqualFunc, bool sourceIsJson = true)
        {
            source.Should().NotBeNull(because: "Source cannot be null!").And.NotBeEmpty(because: "Source cannot be empty!");
            source.Should().IsSerializable<TAssertion>(source, out TAssertion srcObj);
            // var srcObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TAssertion>(source);
            Assert.True(isEqualFunc(target, srcObj));
            return assert.NotBeEmpty(because: "it must not be an emoty string");
        }

        public static AndConstraint<StringAssertions> IsSerializable<TAssertion>(this StringAssertions assert, object obj, out TAssertion result)
        {
            // THIS COULD BE REFINED MORE
            // ....

            try
            {
                var jsn = Newtonsoft.Json.JsonConvert.DeserializeObject<TAssertion>((string)obj);
                jsn.Should().BeOfType<TAssertion>(because: "object can not be serialized to type {}", typeof(TAssertion).Name);
                result = jsn;
                result.Should().BeOfType<TAssertion>();
                return ((string)obj).Should().NotBeNullOrEmpty();
            }
            catch
            {
                obj.Should().BeOfType(typeof(string));
                result =(TAssertion)obj;
                return ((string)obj).Should().NotBeNullOrEmpty();
            }
        }
    }
}
