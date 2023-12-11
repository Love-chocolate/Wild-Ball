using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] ParticleSystem _deathParticle;
    [SerializeField] private GameObject _deathCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.transform.GetChild(0).parent != null)
            {
                other.transform.GetChild(0).parent = null;
            }

            _deathParticle.Play();
            Destroy(other.gameObject);
            StartCoroutine(WaitToShowDeathCanvas());
        }
    }

    private IEnumerator WaitToShowDeathCanvas()
    {
        yield return new WaitForSeconds(2);
        _deathCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
