using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    [SerializeField] private ParticleSystem _coinParticle;

    private void FixedUpdate()
    {
        transform.Rotate(0, 5, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _coinParticle.Play();
            Destroy(gameObject);
        }
    }

}
