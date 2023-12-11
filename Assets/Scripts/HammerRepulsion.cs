using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerRepulsion : MonoBehaviour
{
    [SerializeField] private Rigidbody _playerRigidbody;
    [SerializeField] private float _power;

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 _direction = _playerRigidbody.transform.position - transform.position;
        _playerRigidbody.AddForce(_direction * _power, ForceMode.Impulse);
    }
}
