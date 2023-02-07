using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Registration : MonoBehaviour
{
    [SerializeField] private RegistrationUI _registrationUI;
    [SerializeField] private GameObject _authorationCanvas;

    public void Apply(){
        PlayerPrefs.SetString(PrefsName.PinKey, _registrationUI.pin);
        PlayerPrefs.SetString(PrefsName.FirstNameKey, _registrationUI.firstName);
        PlayerPrefs.SetString(PrefsName.LastNameKey, _registrationUI.lastName);

        _registrationUI.gameObject.SetActive(false);
        _authorationCanvas.SetActive(true);
    }
}
