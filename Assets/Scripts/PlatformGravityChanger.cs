using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGravityChanger : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _rigidbody.useGravity = true;
        }
    }
}
