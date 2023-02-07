using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegistrationUI : MonoBehaviour
{
    [SerializeField] private GameObject _applyButton;

    public string lastName {get; private set;}
    public string firstName {get; private set;}
    public string pin {get; private set;}

    private bool hasLastName = false;
    private bool hasFirstName = false;
    private bool hasPin = false;

    private void Start(){
        _applyButton.SetActive(false);
    }

    public void LastName(string value){
        lastName = value;
        hasLastName = string.IsNullOrEmpty(value) == false;
        SetActiveButton();
    }
    public void FirstName(string value){
        firstName = value;
        hasFirstName = string.IsNullOrEmpty(value) == false;
        SetActiveButton();
    }
    public void Pin(string value){
        pin = value;
        hasPin = string.IsNullOrEmpty(value) == false;
        SetActiveButton();
    }

    private void SetActiveButton(){
        _applyButton.SetActive(hasLastName && hasFirstName && hasPin);
    }
}
