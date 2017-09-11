using System.Collections;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace JsonCreationTool
{
    // Dictionary<TKey, TValue>
    [Serializable]
    public class Serialization<TKey, TValue>
    {
        public List<TKey> keys;
        public List<TValue> values;

        public void Set(Dictionary<TKey, TValue> target)
        {
            keys = new List<TKey>(target.Keys);
            values = new List<TValue>(target.Values);
        }

        public Dictionary<TKey, TValue> GetDictionary()
        {
            var count = Math.Min(keys.Count, values.Count);
            var target = new Dictionary<TKey, TValue>(count);
            for (var i = 0; i < count; ++i)
            {
                target.Add(keys[i], values[i]);
            }
            return target;
        }

    }

    [Serializable]
    public class CustomOptions
    {
        public string Gesture;
        public string Effect;
        public string Color;
    }

}