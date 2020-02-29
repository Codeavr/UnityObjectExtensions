using UnityEngine;

namespace Codeavr.UnityExtensions
{
    public static class UnityExtensions
    {
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            T component = gameObject.GetComponent<T>();

            if (component == null)
            {
                component = gameObject.AddComponent<T>();
            }

            return component;
        }

        /// <summary>
        /// Returns null is UnityEngine.Object is not alive at unmanaged part  
        /// </summary>
        /// <param name="unityObject"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Nullable<T>(this T unityObject) where T : Object
        {
            return unityObject == null ? null : unityObject;
        }

        /// <summary>
        /// Equals operator to compare objects with UnityEngine.Object safe-check
        /// </summary>
        public static bool UnityEquals(this object obj, object other)
        {
            if (obj is UnityEngine.Object uObj1)
            {
                return uObj1.Equals(other);
            }

            if (other is UnityEngine.Object uObj2)
            {
                return uObj2.Equals(obj);
            }

            return Equals(obj, other);
        }

        /// <summary>
        /// Checks if object is alive at unmanaged part, if not UnityEngine.Object passed, uses basic null check
        /// </summary>
        public static bool IsUnityNull(this object obj)
        {
            return obj.UnityEquals(null);
        }
    }
}