using UnityEngine;

namespace Rondo.Generic.Utility {

    public class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour {

        private static T m_Instance;

        public static T Instance {
            get {
                if (m_Instance == null) {
                    m_Instance = FindObjectOfType(typeof(T)) as T;
                }

                return m_Instance;
            }
            set {
                m_Instance = value;
            }
        }
    }
}