using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreathingExercises : MonoBehaviour
{
    [SerializeField] private float _hideShowTextTime = 1.5f; 
    [SerializeField] private BreathingText[] _texts;
    [SerializeField] private Text _text;

    private IEnumerator Start(){
        for (int i = 0; i < _texts.Length; i++)
        {
            _text.text = _texts[i].text;
            //yield return StartCoroutine(ShowText());
            yield return new WaitForSeconds(_texts[i].time);
            //yield return StartCoroutine(HideText());
        }
    }

    private IEnumerator ShowText(){
        Color colorText = _text.color;
        colorText.a = 0;
        _text.color = colorText;
        for (float i = 0; i < 1; i+=Time.deltaTime / _hideShowTextTime)
        {
            yield return null;
            colorText.a = i;
            _text.color = colorText;
        }
            colorText.a = 1;
        _text.color = colorText;
    }
    private IEnumerator HideText(){
        Color colorText = _text.color;
        colorText.a = 1;
        _text.color = colorText;
        for (float i = 1; i > 0; i-=Time.deltaTime / _hideShowTextTime)
        {
            yield return null;
            colorText.a = i;
            _text.color = colorText;
        }
            colorText.a = 0;
        _text.color = colorText;
    }
}

[System.Serializable]
public struct BreathingText{
    public string text;
    public float time;
}
