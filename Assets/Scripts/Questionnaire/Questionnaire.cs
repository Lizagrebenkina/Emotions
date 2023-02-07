using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questionnaire : MonoBehaviour
{
    [SerializeField] private Question[] questions;
    private int _currentIndex = 0;

    public Question GetNext(out bool isOver){
        Question question = questions[_currentIndex];

        _currentIndex++;
        isOver = _currentIndex >= questions.Length;
        if(isOver) _currentIndex = 0;

        return question;
    }
}

[System.Serializable]
public class Question
{
    const string No = "Нет";
    const string MaybeNo = "Скорее нет";
    const string MaybeYes = "Скорее да";
    const string Yes = "Да";

    public string text; //как вы себя чувствуете
    public Answer[] answers;
}


[System.Serializable]
public struct Answer
{
    public string text;
    public int value;

    public Answer(string text){
        this.text = text;
        value = 0;
    }
}

