
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rondo.Generic.Utility {

    public static class ListExtensions {

        public static T GetRandom<T>(this List<T> list) {
            return list[UnityEngine.Random.Range(0, list.Count)];
        }

    }

}