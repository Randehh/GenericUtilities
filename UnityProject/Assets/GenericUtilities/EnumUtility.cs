
using System;
using UnityEngine;

namespace Rondo.Generic.Utility {

    public static class EnumUtility {

        public static T GetRandomEnumValue<T>() {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(UnityEngine.Random.Range(0, v.Length));
        }

    }

}