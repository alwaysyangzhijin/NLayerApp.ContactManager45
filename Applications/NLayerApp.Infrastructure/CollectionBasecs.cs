using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Infrastructure
{
    public abstract class CollectionBase<T> : Collection<T>, IList<T>
    {
        protected CollectionBase() : base(new List<T>()) { }

        protected CollectionBase(IList<T> initialList) : base(initialList) { }

        protected CollectionBase(CollectionBase<T> initialList) : base(initialList) { }

        public void Sort(IComparer<T> comparer)
        {
            var list = Items as List<T>;
            if (list != null)
            {
                list.Sort(comparer);
            }
        }

        public void Sort()
        {
            var list = Items as List<T>;
            if (list != null)
            {
                list.Sort();
            }
        }

        public void AddRange(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection", "Parameter collection is null.");
            }

            foreach (var item in collection)
            {
                Add(item);
            }
        }
    }
}
