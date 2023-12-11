using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] ParticleSystem _deathParticle;
    [SerializeField] private GameObject _deathCanvas;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            if (collision.transform.GetChild(0).parent != null)
            {
                collision.transform.GetChild(0).parent = null;
            }

            _deathParticle.Play();
            Destroy(collision.gameObject);
            StartCoroutine(WaitToShowDeathCanvas());
        }
    }

    private IEnumerator WaitToShowDeathCanvas()
    {
        yield return new WaitForSeconds(2);

        _deathCanvas.SetActive(true);

        Time.timeScale = 0;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
