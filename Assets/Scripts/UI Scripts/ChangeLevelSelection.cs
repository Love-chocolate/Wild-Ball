using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLevelSelection : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Button _nextButton;
    [SerializeField] private Button _previousButton;
    [SerializeField] private Button _mainMenuButton;
    
    private void Start()
    {
        _previousButton.interactable = false;
    }

    public void SwitchToNextLevels()
    {
        _animator.SetTrigger("SwitchToNext");
        _nextButton.interactable = false;
        _previousButton.interactable = true;
    }

    public void SwitchToPreviousLevels()
    {
        _animator.SetTrigger("SwitchToPrevious");
        _nextButton.interactable = true;
        _previousButton.interactable = false;
    }
}
