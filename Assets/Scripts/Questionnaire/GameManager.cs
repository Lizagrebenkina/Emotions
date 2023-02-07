using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _showMenuButton;
 
    [SerializeField] private int _mood = 50;
    [SerializeField] private Result _result;
    [SerializeField] private Text _resultText;

    [SerializeField] private UIPanel _uiPanel;
    [SerializeField] private Questionnaire _questionnaire;
    private Question _currentQuestion;

    private void Start(){
        InitNextQuestion();
    }

    private void InitNextQuestion(){
        _currentQuestion = _questionnaire.GetNext(out bool isOver);
        _uiPanel.InitQuestion(_currentQuestion);
        if(isOver) ShowResult();
    }
    
    public void ApplyResult(){
        int answerValue = _currentQuestion.answers[_uiPanel._answer].value;
        Debug.Log($"Текущий ответ даст {answerValue}, старое значение mood = {_mood}, теперь mood = {_mood + answerValue}");
            AddMood(answerValue);
            InitNextQuestion();
    }

    private void ShowResult(){
        Debug.Log("Вопросы кончились, результат = " + _mood);
        _uiPanel.gameObject.SetActive(false);
        _resultText.text = _result.GetValue(_mood);
        PlayerPrefs.SetInt(PrefsName.QuestionnaireComplete, _mood);
        _showMenuButton.SetActive(true);
    }

    
    private void AddMood(int value)
    {
        _mood += value;
    }
}
