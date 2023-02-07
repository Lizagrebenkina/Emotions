using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AuthorizationUI : MonoBehaviour
{
    [SerializeField] private Text _greetingText;
    [SerializeField] private GameObject _applyButton;
    [SerializeField] private GameObject _recoveryButton;
    public string pin {get; private set;}

    private void OnEnable(){
        _recoveryButton.SetActive(false);

        string firstName = PlayerPrefs.GetString(PrefsName.FirstNameKey);
        _greetingText.text = $"{firstName},\nДобро пожаловать!";
    }

    public void SetPin(string value){
        pin = value;
        bool hasPin = string.IsNullOrEmpty(value) == false;
        _applyButton.SetActive(hasPin);
    }

    public void ActivateRecoveryButton(){
        _recoveryButton.SetActive(true);
    }
}
