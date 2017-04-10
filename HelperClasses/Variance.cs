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
        public object ValA { get; set; }
        public object ValB { get; set; }

        public override string ToString()
        {
            return $"{Prop} : {ValA} <> {ValB}";
        }
    }

    public static class VarienceCheck
    {
        public static List<Variance> DetailedCompare<T>(this T val1, T val2, int instance = -1)
        {
            var variances = new List<Variance>();
            FieldInfo[] fi = val1.GetType().GetFields();
            foreach (FieldInfo f in fi)
            {
                var v = new Variance()
                {
                    Prop = f.Name + ((instance > -1) ? instance.ToString() : ""),
                    ValA = f.GetValue(val1),
                    ValB = f.GetValue(val2)
                };
                if (v.ValA == null | v.ValB == null)
                {
                    variances.Add(v);
                    continue;
                }

                if (f.GetType().GetInterfaces().Contains(typeof(IList)))
                {
                    var valA = (IList)f.GetValue(val1);
                    var valB = (IList)f.GetValue(val2);
                    for (int i = 0; i < valA.Count; i++)
                    {
                        if (i > valB.Count)
                        {
                            variances.Add(new Variance() { Prop = f.Name + i.ToString(), ValA = i.ToString(), ValB = "NA" });
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
                            variances.Add(new Variance() { Prop = f.Name + j.ToString(), ValB = j.ToString(), ValA = "NA" });
                        }
                    }
                }
                else
                {
                    if (f.GetType().IsSimple())
                    {
                        if (f.GetType() == typeof(Nullable<decimal>))
                        {
                            var v1 = (decimal?)v.ValA;
                            var v2 = (decimal?)v.ValB;
                            if ((v1.HasValue == false && v2.Value == 0)||
                                (v2.HasValue == false && v1.Value == 0))
                            {
                                //do nothing
                                continue;
                            }
                        }

                        if (f.GetType() == typeof(bool?))
                        {
                            var v1 = (bool?)v.ValA;
                            var v2 = (bool?)v.ValB;
                            if ((v1.HasValue == false && v2.Value == false) ||
                                (v2.HasValue == false && v1.Value == false))
                            {
                                //do nothing
                                continue;
                            }
                        }

                        if (!v.ValA.Equals(v.ValB))
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

        public static bool IsSimple(this Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                return type.GetGenericArguments()[0].GetType().IsSimple();

            return type.IsPrimitive ||
                type.IsEnum ||
                type.Equals(typeof(decimal)) ||
                type.Equals(typeof(string));
        }
    }
}