using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class GenericDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public GenericDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] keyTempArray = keys;
            TValue[] valueTempArray = values;


            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];


            for (int i = 0; i < keyTempArray.Length; i++)
            {
                keys[i] = keyTempArray[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < valueTempArray.Length; i++)
            {
                values[i] = valueTempArray[i];
            }
            values[values.Length - 1] = value;
        }
        public int Length
        {
            get { return keys.Length; }
        }
        public TValue[] Values
        {
            get { return values; }
        }
        public TKey[] Keys
        {
            get { return keys; }
        }
    }
}
