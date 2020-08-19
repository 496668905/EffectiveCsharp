using EffectiveCsharp._1To25;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static System.Console;
namespace EffectiveCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            ICollection<int> lst = new Collection<int> { 1, 3, 5 };
            ReverseEnumerable<int> reverseList = new ReverseEnumerable<int>(lst);
            foreach (var item in reverseList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
