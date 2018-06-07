using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Contactos.Helpers
{
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public int key { get; set; }

        public Grouping (K key, IEnumerable<T> items)
        {
            this.key = key;
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }
    }
}
