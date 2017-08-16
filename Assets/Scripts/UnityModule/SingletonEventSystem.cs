using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityModule {

    public class SingletonEventSystem : MonoBehaviour {

        private void Start() {
            if (FindObjectOfType<EventSystem>() == default(EventSystem)) {
                this.gameObject.AddComponent<EventSystem>();
                this.gameObject.AddComponent<StandaloneInputModule>();
            }
        }

    }

}