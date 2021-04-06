using FluentAssertions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xunit;

namespace EncompassApi.xUnitTests.Extensions
{
    public static class JObjectExtensions
    {
        /// <summary>
        /// Asserts that the jObjects are of certain type
        /// </summary>
        public static void ShouldBeOfType<TObject>(this JObject[] jObjects)
        {
            // THIS COULD BE REFINED MORE
            // ....
            foreach (var item in jObjects)
            {
                Assert.IsType<TObject>(item.ToObject<TObject>());
            }
        }

        /// <summary>
        /// Asserts that the two objects are equal based on an input logic
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="isEqualFunc">Input logic to compare</param>
        public static void AreEqual<TObject>(this JObject[] target, TObject[] source, Func<TObject, TObject, bool> isEqualFunc)
        {
            for (int i = 0; i < target.Length; i++)
            {
                Assert.True(isEqualFunc(source[i], target[i].ToObject<TObject>()));
            }
        }

        public static TObject[] ShouldBeObjectArray<TObject>(this string source, params string[] properties)
        {
            var objs = Newtonsoft.Json.JsonConvert.DeserializeObject<TObject[]>(source);
            foreach (var property in properties)
            {
                var p = objs[0].GetType().GetProperty(property);
                Assert.True(p != null);
                Assert.True(p.GetValue(objs[0]) != null);
            }
            
            return objs;
        }
    }
}
