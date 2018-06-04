using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests {

    public class SingletonEventSystemTest {

        [UnityTest]
        public IEnumerator BasicTest() {
            SceneManager.LoadScene("Tests/Scenes/Test", LoadSceneMode.Single);
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();
            Assert.AreEqual(1, Object.FindObjectsOfType<EventSystem>().Length);
            SceneManager.LoadScene("Tests/Scenes/Test", LoadSceneMode.Additive);
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();
            Assert.AreEqual(1, Object.FindObjectsOfType<EventSystem>().Length);
        }

    }

}