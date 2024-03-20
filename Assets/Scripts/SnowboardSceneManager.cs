using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SnowboardSceneManager
{
    public class SceneManager
    {
        public static IEnumerator Restart(int scene, float delay)
        {
            yield return new WaitForSeconds(delay);
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
        }
    }
}
