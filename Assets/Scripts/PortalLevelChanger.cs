using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalLevelChanger : MonoBehaviour
{
    [SerializeField] private byte _sceneIndex;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(_sceneIndex);
    }
}
