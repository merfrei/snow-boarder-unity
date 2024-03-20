using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SnowboardSceneManager;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float delaySecs = 2f;
    [SerializeField] GameObject surface = null;
    [SerializeField] ParticleSystem crashEffect = null;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            if (this.crashEffect != null)
            {
                this.crashEffect.Play();
            }
            if (this.surface != null)
            {
                SurfaceEffector2D surface = this.surface.GetComponent<SurfaceEffector2D>();
                surface.speed = 0;
            }
            StartCoroutine(SceneManager.Restart(0, this.delaySecs));
        }
    }
}
