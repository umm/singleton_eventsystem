using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityModule {

    public class SingletonEventSystem : MonoBehaviour {

        private void Start() {
            if (FindObjectOfType<EventSystem>() == default(EventSystem)) {
                GameObject go = new GameObject(this.GetType().Name);
                go.AddComponent<EventSystem>();
                go.AddComponent<StandaloneInputModule>();
                DontDestroyOnLoad(go);
            }
        }

    }

}