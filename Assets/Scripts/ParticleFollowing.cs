using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFollowing : MonoBehaviour
{
    [SerializeField] private Transform _playerTranform;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - _playerTranform.position;
    }

    private void FixedUpdate()
    {
        transform.position = _playerTranform.position + offset;
    }
}
