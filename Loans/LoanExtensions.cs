using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EncompassRest.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Loans
{
    public static class LoanExtensions
    {
        public static async Task<object> GetEncompassFieldValue(this Loan loan, string fieldId)
        {
            var fieldPath = await loan.Client.Schema.GetFieldPathAsync(fieldId);
            return GetLoanValueRecursive(loan, fieldPath);
        }

        #region recursive
        /// <summary>
        /// Returns an object from the specific path
        /// if there is a list entity and there is no specified query or index then it will default to the first item found
        /// </summary>
        /// <param name="loan"></param>
        /// <param name="fieldPath"></param>
        /// <param name="ApplicationID"></param>
        /// <returns></returns>
        public static object GetLoanValueRecursive(this Loan loan, string fieldPath, int index = -1)
        {
            return GetPropValueRecursive(loan, fieldPath, index);
        }

        private static object GetPropValueRecursive(this object obj, string name, int Index = -1, string Query=null)
        {
            if (name.ToLower().StartsWith("loan."))
                name = name.Substring(5);

            string part;
            string remaining;
            int index = Index;
            string query = Query;

            if (name.Contains("."))
            {
                //ignore {} and []
                int astart = name.IndexOf("{");
                int aend = name.IndexOf("}");
                int bstart = name.IndexOf("[");
                int bend = name.IndexOf("]");

                int dot = name.IndexOf(".");

                if (astart < dot && dot < aend)
                    dot = name.Substring(aend).IndexOf(".") + aend;

                if (bstart < dot && dot < bend)
                    dot = name.Substring(bend).IndexOf(".") + bend;


                part = name.Substring(0, dot);
                //if (name == "")
                //{
                //    name = part;
                //}
                //else
                //{
                //    name = name + "." + part;
                //}
                if (name.Length == part.Length)
                    remaining = "";
                else
                    remaining = name.Substring(part.Length + 1);
            }
            else
            {
                part = name;
                remaining = "";
            }
            if (obj == null) { return null; }

            if (part.Contains("["))
            {
                var indextmp = Regex.Match(part, @"\[([^]]*)\]").Groups[1].Value;
                if (!int.TryParse(indextmp, out index))
                {
                    return null;
                }

                part = part.Substring(0, part.IndexOf("["));
            }
            if (part.Contains("{"))
            {
                //use dynamic linq here to parse inline queries.
                query = Regex.Match(part, @"\{([^]]*)\}").Groups[1].Value;
                part = part.Substring(0, part.IndexOf("{"));
                if (index >= 0)
                    index = -1;
            }

            if (part == "Application")
                part = "applications";

            if (obj is IList)
            {
                var items = (IList)obj;
                //get Item from list.
                if (index >= 0)
                {
                    try
                    {
                        obj = items[index];
                        index = -1;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        return null;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        return null;
                    }
                }
                else if (query != null && query != "")
                {

                    var results = items.AsQueryable().Where(query);
                    query = null;
                    if (results.Count() == 0)
                    {
                        return null;
                    }
                    else
                    {
                        IEnumerator enumer = results.GetEnumerator();
                        enumer.MoveNext();
                        obj = enumer.Current;
                    }
                }
                else
                {
                    obj = items[0];
                }
            }

            Type type = obj.GetType();
            PropertyInfo info = type.GetProperty(part);

            if (info == null) //property is not in json data
            {
                return null;
            }

            obj = info.GetValue(obj, null);
            if (remaining != "")
            {
                return obj.GetPropValueRecursive(remaining, index,query);
            }
            else
            {

                return obj;
            }
        }
        #endregion

        #region JSON
        public static JObject GetLoanValueJSONRecursive(this Loan loan, string fieldPath)
        {
            var ex = new ExpandoObject();
            try
            {
                loan.GetPropValueRecursive(ex, fieldPath);
            }
            catch (InvalidFieldException IFE)
            {
                return JObject.Parse("{\"Error\":\"Invalid Field - " + IFE.Field + "\"}");
            }
            
            return JObject.Parse(JsonConvert.SerializeObject(ex));
        }

        private static void GetPropValueRecursive(this object obj, ExpandoObject jo, string name, string fullName = "", int Index = -1, string Query = null)
        {
            if (name.ToLower().StartsWith("loan."))
            {
                name = name.Substring(5);
            }


            string part;
            string remaining;
            string query = Query;
            int index = Index;

            if (name.Contains("."))
            {
                //ignore {} and []
                int astart = name.IndexOf("{");
                int aend = name.IndexOf("}");
                int bstart = name.IndexOf("[");
                int bend = name.IndexOf("]");

                int dot = name.IndexOf(".");

                if (astart<dot && dot<aend)
                    dot = name.Substring(aend).IndexOf(".") + aend;

                if (bstart < dot && dot < bend)
                    dot = name.Substring(bend).IndexOf(".") + bend;


                part = name.Substring(0, dot);
                if (fullName == "")
                {
                    fullName = part;
                }
                else
                {
                    fullName = fullName + "." + part;
                }
                if (name.Length == part.Length)
                    remaining = "";
                else
                    remaining = name.Substring(part.Length + 1);
            }
            else
            {
                fullName = name;
                part = name;
                remaining = "";
            }
            if (obj == null) { return; }

            if (part.Contains("["))
            {
                var indextmp = Regex.Match(part, @"\[([^]]*)\]").Groups[1].Value;
                if (!int.TryParse(indextmp, out index))
                {
                    return;
                }

                part = part.Substring(0, part.IndexOf("["));
            }
            if (part.Contains("{"))
            {
                //use dynamic linq here to parse inline queries.
                query = Regex.Match(part, @"\{([^]]*)\}").Groups[1].Value;
                part = part.Substring(0, part.IndexOf("{"));
            }


            if (part == "Application")
                part = "applications";

            //obj.GetType().GetInterface("IList") != null
            if (obj is IList && (remaining != "" || query != "" || index!= -1))
            {
                var items = (IList)obj;
                //get Item from list.
                if (index >= 0)
                {
                    try
                    {
                        obj = items[index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        return;
                    }
                }
                else if (query!= null && query != "")
                {

                    var results = items.AsQueryable().Where(query);
                    query = null;
                    if (results.Count() == 0)
                    {
                        return;
                    }
                    else if (results.Count() == 1)
                    {
                        IEnumerator enumer = results.GetEnumerator();
                        enumer.MoveNext();
                        obj = enumer.Current; 
                    }
                    else
                    {
                        IEnumerable<object> subitems = results as IEnumerable<object>;
                        ExpandoObject localJO = new ExpandoObject();
                        var ljo = localJO as IDictionary<string, object>;
                        //List<object> results = new List<object>();
                        int i = 0;
                        foreach (object item in subitems)
                        {
                            ExpandoObject leo = new ExpandoObject();
                            Type t = item.GetType();
                            PropertyInfo inf = t.GetProperty(part);
                            obj = inf.GetValue(item, null);

                            obj.GetPropValueRecursive(leo, remaining, "", index,query);
                            ljo.Add(i.ToString(), leo);
                            i++;
                        }
                        var REGnam = new Regex("\\[.*?\\]");
                        var nam = REGnam.Replace(fullName, string.Empty);

                        var expandoDict = jo as IDictionary<string, object>;
                        expandoDict.Add(nam, localJO);
                        return;
                    }
                }
                else
                {
                    ExpandoObject localJO = new ExpandoObject();
                    var ljo = localJO as IDictionary<string, object>;
                    //List<object> results = new List<object>();
                    int i = 0;
                    foreach (object item in items)
                    {
                        ExpandoObject leo = new ExpandoObject();
                        Type t = item.GetType();
                        PropertyInfo inf = t.GetProperty(part);
                        obj = inf.GetValue(item, null);
                        
                        obj.GetPropValueRecursive(leo, remaining, "", index,query);
                        ljo.Add(i.ToString(), leo);
                        i++;
                    }
                    var REGnam = new Regex("\\[.*?\\]");
                    var nam = REGnam.Replace(fullName, string.Empty);

                    var expandoDict = jo as IDictionary<string, object>;
                    expandoDict.Add(nam, localJO);
                    return;
                }
            }

            Type type = obj.GetType();
            PropertyInfo info = type.GetProperty(part);
            if (info == null)
            {
                throw new InvalidFieldException(fullName);
            }
            obj = info.GetValue(obj, null);
            if (remaining != "")
            {
                
                obj.GetPropValueRecursive(jo, remaining, fullName, index,query);


                return;
            }
            else
            {
                var expandoDict = jo as IDictionary<string, object>;
                if (expandoDict.ContainsKey(fullName))
                    expandoDict[fullName] = obj;
                else
                    expandoDict.Add(fullName, obj);
                return;
            }
        }
        #endregion
    }
}