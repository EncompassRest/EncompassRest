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
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;

namespace EncompassApi.xUnitTests.Extensions
{
    public static class GenericCollectionAssertionsExtensions
    {

        /// <summary>
        /// <para>Compares target and source base on an inputed logic</para>
        /// </summary>
        /// <typeparam name="TAssertions"></typeparam>
        /// <param name="isEqualFunc">Comparison logic</param>
        /// <returns></returns>
        public static AndConstraint<GenericCollectionAssertions<TAssertions>> BeEqual<TAssertions>(this GenericCollectionAssertions<TAssertions> assert,
             IEnumerable<TAssertions> target, IEnumerable<TAssertions> source, Func<TAssertions, TAssertions, bool> isEqualFunc, string because = "two arrays are not equal")
        {
            var srcAry = source.ToArray();
            var trgtAry = target.ToArray();

            for (int i = 0; i < target.Count(); i++)
            {
                Assert.True(isEqualFunc(srcAry[i], trgtAry[i]));
            }

            return assert.NotBeEmpty(because: because);
        }

    



        public static IEnumerable<TObject> BeSerializable<TAssertion, TObject>(this GenericCollectionAssertions<TAssertion> assert, IEnumerable<JObject> payloads)
        {
            // THIS COULD BE REFINED MORE
            // ....
            var list = new List<TObject>();
            foreach (var item in payloads)
            {
                try
                {
                    var jsn = item.ToString();
                    var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<TObject>(jsn);
                    Assert.IsType<TObject>(obj);
                    list.Add(obj);
                }
                catch
                {
                    assert.BeOfType<TObject>();
                }
            }
            assert.Should().NotBeNull(because: "payloads must not be null");
            return list;
        }

        public static AndConstraint<GenericCollectionAssertions<TAssertion>> BeOfType<TAssertion>(this GenericCollectionAssertions<TAssertion> assert)
        {
            return assert.HaveCount(0);
        }

    }
}
