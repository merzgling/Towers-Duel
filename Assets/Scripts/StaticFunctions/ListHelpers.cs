using System.Collections.Generic;
using UnityEngine;

namespace StaticFunctions
{
    public static class ListHelpers
    {
        public static T GetRandom<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }
    }
}