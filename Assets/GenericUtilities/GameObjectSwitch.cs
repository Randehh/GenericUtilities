using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rondo.Generic.Utility {

    public class GameObjectSwitch : MonoBehaviour {

        public GameObject firstActiveObj;
        public List<GameObject> objects = new List<GameObject>();

        private void Start() {
            SetActive(firstActiveObj);
        }

        public void SetActive(GameObject activeObj) {
            if (!objects.Contains(activeObj)) {
                Debug.LogWarning("Object " + activeObj.name + " is not added to this switch.");
                return;
            }

            foreach (GameObject obj in objects) {
                obj.SetActive(obj == activeObj);
            }
        }
    }

}