using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private byte _sceneIndex;

    public void LoadScene()
    {
        SceneManager.LoadScene(_sceneIndex);
    }

    public void RestartGame()
    {
        int _currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(_currentSceneIndex);
    }
}
