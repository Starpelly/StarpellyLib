using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Pelly
{
    public class Math : MonoBehaviour
    {
        public static float Round2NearestQuarter(float a)
        {
            return a = a - (a % 0.25f);
        }

        public static float Difference(float num1, float num2)
        {
            float cout;
            cout = Mathf.Max(num2, num1) - Mathf.Min(num1, num2);
            return cout;
        }

        public static float GetClosestInList(List<float> list, float compareTo)
        {
            if (list.Count > 0)
                return list.Aggregate((x, y) => Mathf.Abs(x - compareTo) < Mathf.Abs(y - compareTo) ? x : y);
            else
                return -40;
        }

        public static float GetDecimalFromFloat(float number)
        {
            return number % 1; // this is simple as fuck, but i'm dumb and forget this all the time
        }

        public static float Normalize(float val, float min, float max)
        {
            return (val - min) / (max - min);
        }
    }
}
