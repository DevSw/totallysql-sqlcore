#define SqlCore
#if SqlStub
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLCore
{

    public class SqlCore
    {
        public static bool IsEnabled
        {
            get { return false; }
        }
    }

    public class ThreadSafeDictionary<K, V>
    {

        public void Add(K key, V value)
        {
            throw new NotImplementedException("The installed version of SQLCore is non-functional - for Safe mode deployment only");
        }

        public V this[K key]
        {
            get
            {
                throw new NotImplementedException("The installed version of SQLCore is non-functional - for Safe mode deployment only");
            }

            set
            {
                throw new NotImplementedException("The installed version of SQLCore is non-functional - for Safe mode deployment only");
            }
        }

        public bool Remove(K key)
        {
            throw new NotImplementedException("The installed version of SQLCore is non-functional - for Safe mode deployment only");
        }

        public bool ContainsKey(K key)
        {
            throw new NotImplementedException("The installed version of SQLCore is non-functional - for Safe mode deployment only");
        }
    }
}
#endif