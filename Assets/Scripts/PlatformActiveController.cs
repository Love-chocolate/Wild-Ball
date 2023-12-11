using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformActiveController : MonoBehaviour
{
    [SerializeField] private GameObject _platform;

    private void OnCollisionEnter(Collision collision)
    {
        _platform.SetActive(true);   
    }
}
