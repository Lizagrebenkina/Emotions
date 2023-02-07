using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    [SerializeField] private GameObject _registrationCanvas;
    [SerializeField] private GameObject _authorationCanvas;
    private void Start(){
        if(PlayerPrefs.HasKey(PrefsName.PinKey)){
            _authorationCanvas.SetActive(true);
        }else{
            _registrationCanvas.SetActive(true);
        }

        //string pin = PlayerPrefs.GetString("PIN");
    }
}
