using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Authorization : MonoBehaviour
{
    private const int MaxIterationInputPin = 3;

    [SerializeField] private AuthorizationUI _authorationUI;
    [SerializeField] private NextSceneManager _nextSceneManager;
    private int _recoveryCounter;

    private void Start(){
        _recoveryCounter = MaxIterationInputPin;
    }

    public void Apply(){
        string validPin = PlayerPrefs.GetString(PrefsName.PinKey);
        string currentKey = _authorationUI.pin;

        if(validPin == currentKey) ValidPin();
        else NotValidPin();
    }

    private void NotValidPin(){
        Debug.LogError("Пин не верен, тут нужно сделать что-то красивое");
        _recoveryCounter--;
        if(_recoveryCounter <= 0) _authorationUI.ActivateRecoveryButton();
    }

    private void ValidPin(){
        _nextSceneManager.LoadNextScene();
    }
}
