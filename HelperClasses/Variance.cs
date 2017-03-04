using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EncompassREST.HelperClasses
{
    public class Variance
    {
        public string Prop { get; set; }
        public object valA { get; set; }
        public object valB { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1} <> {2}",Prop,valA,valB);
        }
    }

    public static class VarienceCheck
    {
        public static List<Variance> DetailedCompare<T>(this T val1, T val2, int instance = -1)
        {
            List<Variance> variances = new List<Variance>();
            FieldInfo[] fi = val1.GetType().GetFields();
            foreach (FieldInfo f in fi)
            {
                Variance v = new Variance();
                v.Prop = f.Name + ((instance > -1) ? instance.ToString() : "");
                v.valA = f.GetValue(val1);
                v.valB = f.GetValue(val2);

                if (v.valA == null | v.valB == null)
                {
                    variances.Add(v);
                    continue;
                }

                if (f.GetType().GetInterfaces().Contains(typeof(IList)))
                {
                    IList valA = (IList)f.GetValue(val1);
                    IList valB = (IList)f.GetValue(val2);
                    for (int i = 0; i < valA.Count; i++)
                    {
                        if (i > valB.Count)
                        {
                            variances.Add(new Variance() { Prop = f.Name + i.ToString(), valA = i.ToString(), valB = "NA" });
                        }
                        else
                        {
                            variances.AddRange(DetailedCompare(valA[i], valB[i]));
                        }
                    }
                    if (valB.Count > valA.Count)
                    {
                        for (int j = valA.Count; j < valB.Count; j++)
                        {
                            variances.Add(new Variance() { Prop = f.Name + j.ToString(), valB = j.ToString(), valA = "NA" });
                        }
                    }
                }
                else
                {
                    if (f.GetType().isSimple())
                    {
                        if (f.GetType() == typeof(Nullable<decimal>))
                        {
                            Nullable<decimal> v1 = (Nullable<decimal>)v.valA;
                            Nullable<decimal> v2 = (Nullable<decimal>)v.valB;
                            if ((v1.HasValue == false && v2.Value == 0)||
                                (v2.HasValue == false && v1.Value == 0))
                            {
                                //do nothing
                                continue;
                            }
                        }

                        if (f.GetType() == typeof(Nullable<bool>))
                        {
                            var v1 = (Nullable<bool>)v.valA;
                            var v2 = (Nullable<bool>)v.valB;
                            if ((v1.HasValue == false && v2.Value == false) ||
                                (v2.HasValue == false && v1.Value == false))
                            {
                                //do nothing
                                continue;
                            }
                        }

                        if (!v.valA.Equals(v.valB))
                            variances.Add(v);
                    }
                    else
                    {
                        variances.AddRange(DetailedCompare(f.GetValue(val1), f.GetValue(val2)));
                    }
                }
            }
            return variances;

        }


        public static bool isSimple(this Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                return type.GetGenericArguments()[0].GetType().isSimple();

            return type.IsPrimitive ||
                type.IsEnum ||
                type.Equals(typeof(decimal)) ||
                type.Equals(typeof(string));
        }
    }
}