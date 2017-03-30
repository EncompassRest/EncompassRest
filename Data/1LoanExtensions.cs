using EncompassREST.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EncompassREST.Data 
{
    public static class LoanExtensions
    {
        public static async Task PopulateLoan(this Loan tLoan, string JsonData, Session Session)
        {
            //Loan l = await JsonConvert.DeserializeObjectAsync<Data.Loan>(JsonData);
            await Task.Factory.StartNew(() => JsonConvert.PopulateObject(JsonData, tLoan));
            tLoan._StartingData = JsonData;
            tLoan._Session = Session;
            return;
        }

        public static async Task<Loan> PatchLoanAsync(this Loan tLoan, string JsonData)
        {
            return await tLoan.Session.Loans.PatchLoanAsync(JsonData, tLoan.encompassId);
        }

        public static string GetLoanValue(this Loan tLoan, string FieldPath, int ApplicationID = 0)
        {
            object val = GetPropValue(tLoan, FieldPath, ApplicationID);
            if (val != null)
                return val.ToString();
            else
                return "";
        }

        #region Regular
        public static async Task<object> GetEncompassFieldValue(this Loan tLoan, string EncompassFieldID, int ApplicationID = 0)
        {

            var fieldPath = await tLoan.Session.Schemas.GetFieldPathAsync(EncompassFieldID);
            var fieldBreadcrumbs = fieldPath.Split('.').ToList();
            dynamic placeholder;
            //for (int i = 1;i<fieldBreadcrumbs.Count();i++)
            //{
            //    string nextItem = fieldBreadcrumbs[i];

            //}
            placeholder = GetPropValue(tLoan, fieldPath, ApplicationID);

            return placeholder;
        }
        private static Object GetPropValue(this Object obj, String name, int ApplicationID = 0)
        {
            if (name.ToLower().StartsWith("loan."))
                name = name.Substring(5);

            //string part = name.Substring(0, name.IndexOf("."));
            //string remaining = name.Substring(part.Length);

            foreach (String part in name.Split('.'))
            {
                if (obj == null) { return null; }

                if (obj.GetType().GetInterface("IList") != null)
                {
                    var items = (IList)obj;
                    //get Item from list.
                    if (items.Count == 1)
                        obj = items[0];
                    else
                    {
                        List<object> results = new List<object>();
                        foreach (object item in items)
                        {
                            Type t = obj.GetType();
                            PropertyInfo inf = t.GetProperty(part);
                            //obj = inf.GetValue(item, null);
                            //item.GetPropValue()
                        }
                    }
                }

                Type type = obj.GetType();
                PropertyInfo info = type.GetProperty(part);
                if (info == null)
                {
                    if (part == "Application")
                    {
                        info = type.GetProperty("Applications");
                        if (info == null)
                            return null;

                        IList oList = info.GetValue(obj, null) as IList;
                        if (ApplicationID >= oList.Count)
                            return null;
                        obj = oList[ApplicationID];
                        continue;

                    }
                    else
                        return null;
                }

                obj = info.GetValue(obj, null);
            }
            return obj;
        }

        private static T GetPropValue<T>(this Object obj, String name)
        {
            Object retval = GetPropValue(obj, name);
            if (retval == null) { return default(T); }

            // throws InvalidCastException if types are incompatible
            return (T)retval;
        }
        #endregion

        #region recursive
        /// <summary>
        /// Returns an object from the specific path
        /// if there is a list entity and there is no specified query or index then it will default to the first item found
        /// </summary>
        /// <param name="tLoan"></param>
        /// <param name="FieldPath"></param>
        /// <param name="ApplicationID"></param>
        /// <returns></returns>
        public static object GetLoanValueRecursive(this Loan tLoan, string FieldPath, int Index = -1)
        {
            object val = GetPropValueRecursive(tLoan, FieldPath, Index);
            return val;
        }

        private static Object GetPropValueRecursive(this Object obj, String name, int Index = -1, string Query=null)
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
        public static JObject GetLoanValueJSONRecursive(this Loan tLoan, string FieldPath)
        {
            var ex = new ExpandoObject();
            try
            {
                tLoan.GetPropValueRecursive(ex, FieldPath);
            }
            catch (InvalidFieldException IFE)
            {
                return JObject.Parse("{\"Error\":\"Invalid Field - " + IFE.Field + "\"}");
            }
            
            return JObject.Parse(JsonConvert.SerializeObject(ex));
        }
        private static void GetPropValueRecursive(this Object obj, ExpandoObject jo, string name,string FullName = "",  int Index = -1)
        {
            if (name.ToLower().StartsWith("loan."))
            {
                name = name.Substring(5);
            }


            string part;
            string remaining;
            string query = "";
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
                    dot = name.Substring(aend).IndexOf(".") + aend+2;

                if (bstart < dot && dot < bend)
                    dot = name.Substring(bend).IndexOf(".") + bend+2;


                part = name.Substring(0, dot);
                if (FullName == "")
                {
                    FullName = part;
                }
                else
                {
                    FullName = FullName + "." + part;
                }
                if (name.Length == part.Length)
                    remaining = "";
                else
                    remaining = name.Substring(part.Length + 1);
            }
            else
            {
                FullName = name;
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
                else if (query != "")
                {

                    var results = items.AsQueryable().Where(query);
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

                            obj.GetPropValueRecursive(leo, remaining, "", index);
                            ljo.Add(i.ToString(), leo);
                            i++;
                        }
                        var REGnam = new Regex("\\[.*?\\]");
                        var nam = REGnam.Replace(FullName, string.Empty);

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
                        
                        obj.GetPropValueRecursive(leo, remaining, "", index);
                        ljo.Add(i.ToString(), leo);
                        i++;
                    }
                    var REGnam = new Regex("\\[.*?\\]");
                    var nam = REGnam.Replace(FullName, string.Empty);

                    var expandoDict = jo as IDictionary<string, object>;
                    expandoDict.Add(nam, localJO);
                    return;
                }
            }

            Type type = obj.GetType();
            PropertyInfo info = type.GetProperty(part);
            if (info == null)
            {
                throw new InvalidFieldException(FullName);
            }
            obj = info.GetValue(obj, null);
            if (remaining != "")
            {
                
                obj.GetPropValueRecursive(jo, remaining, FullName, index);


                return;
            }
            else
            {
                var expandoDict = jo as IDictionary<string, object>;
                if (expandoDict.ContainsKey(FullName))
                    expandoDict[FullName] = obj;
                else
                    expandoDict.Add(FullName, obj);
                return;
            }
        }
        #endregion







        


        

    }
}
