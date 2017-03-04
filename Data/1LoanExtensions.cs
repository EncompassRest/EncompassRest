using EncompassREST.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
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

        public static string GetLoanValueRecursive(this Loan tLoan, string FieldPath, int ApplicationID = 0)
        {
            object val = GetPropValueRecursive(tLoan, FieldPath, ApplicationID);
            if (val != null)
                return val.ToString();
            else
                return "";
        }

        private static Object GetPropValueRecursive(this Object obj, String name, int Index = -1)
        {
            if (name.ToLower().StartsWith("loan."))
                name = name.Substring(5);

            string part;
            string remaining;
            int index = Index;

            if (name.Contains("."))
            {
                part = name.Substring(0, name.IndexOf("."));
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
                int.TryParse(indextmp, out index);
                part = part.Substring(0, part.IndexOf("["));
            }
            if (part == "Application")
                part = "applications";

            if (obj.GetType().GetInterface("IList") != null)
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
                        return null;
                    }
                }
                else
                {
                    List<object> results = new List<object>();
                    foreach (object item in items)
                    {
                        Type t = item.GetType();
                        PropertyInfo inf = t.GetProperty(part);
                        obj = inf.GetValue(item, null);
                        results.Add(obj.GetPropValueRecursive(remaining, index));
                    }
                    return string.Join(";", results.Where(x => x != null));
                }
            }

            Type type = obj.GetType();
            PropertyInfo info = type.GetProperty(part);
            obj = info.GetValue(obj, null);
            if (remaining != "")
            {
                return obj.GetPropValueRecursive(remaining, index);
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
            int index = Index;

            if (name.Contains("."))
            {
                part = name.Substring(0, name.IndexOf("."));
                if (FullName == "")
                {
                    FullName = part;
                }
                else
                {
                    FullName = FullName + "." + part;
                }
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
                int.TryParse(indextmp, out index);
                part = part.Substring(0, part.IndexOf("["));
            }
            if (part.Contains("{"))
            {
                //use dynamic linq here to parse inline queries.
            }


            if (part == "Application")
                part = "applications";

            //obj.GetType().GetInterface("IList") != null
            if (obj is IList && remaining != "")
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
