using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel : MonoBehaviour
{
    [SerializeField] private Text _questionText;
    [SerializeField] private Text[] _answers;
    [SerializeField] private Toggle[] _answerToggles;
    public int _answer { get; private set;}

    public void InitQuestion(Question question){
        _questionText.text = question.text;

        for(int i = 0; i < 4; i++){
            _answers[i].text = question.answers[i].text;
        }

        _answer = 0;
        _answerToggles[0].isOn = true;
    }

    public void ChangeToggles(bool value){
        if(value == false) return;

        for(int i = 0; i < 4; i++){
            if(_answerToggles[i].isOn == false) continue;

            _answer = i;
        }
    }
}
