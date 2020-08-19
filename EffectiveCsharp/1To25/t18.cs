using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveCsharp._1To25
{
    /// <summary>
    /// 只定义刚好够用的约束条件
    /// </summary>
    public static class t18
    {
        public static bool AreEqual<T>(T left, T right) where T : IComparable<T>
            => left.CompareTo(right) == 0;

        public static T FirstOrDefault<T>(this IEnumerable<T> sequence, Predicate<T> test)
        {
            foreach (var item in sequence)
            {
                if (test(item))
                {
                    return item;
                }
            }
            return default(T);
        }
    }
}
