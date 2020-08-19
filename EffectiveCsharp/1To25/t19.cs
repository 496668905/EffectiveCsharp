using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EffectiveCsharp._1To25
{
    /// <summary>
    /// 通过运行期类型检查实现特定的泛型算法
    /// </summary>
    public class t19
    {
        
    }
    public class ReverseEnumerable<T> : IEnumerable<T>
    {
        private class ReverseEnumerator : IEnumerator<T>
        {
            int currentIndex;
            IList<T> collection;
            public ReverseEnumerator(IList<T> srcCollection)
            {
                currentIndex = srcCollection.Count;
                collection = srcCollection;
            }
            public T Current => collection[currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                return --currentIndex >= 0;
            }

            public void Reset()
            {
                currentIndex = collection.Count;
            }
        }
        IEnumerable<T> sourceSequence;
        IList<T> originalSequence;
        public ReverseEnumerable(IEnumerable<T> sequence)
        {
            sourceSequence = sequence;
        }
        public ReverseEnumerable(IList<T> sequence)
        {
            sourceSequence = sequence;
            originalSequence = sequence;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (originalSequence == null)
            {
                if (sourceSequence is Collection<T>)
                {
                    ICollection<T> source = sourceSequence as ICollection<T>;
                    originalSequence = new List<T>(source.Count);
                }
                else
                {
                    originalSequence = new List<T>();
                }
                foreach (T item in sourceSequence)
                {
                    originalSequence.Add(item);
                }
            }
            return new ReverseEnumerator(originalSequence);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
