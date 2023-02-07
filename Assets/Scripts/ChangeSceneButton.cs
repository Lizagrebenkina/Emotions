using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    [SerializeField] private SceneType _sceneType;
    public void Click(){ 
        string sceneName = PrefsName.MenuSceneName;
        switch (_sceneType)
        {
            case SceneType.Start:
                break;
            case SceneType.Questionnaire:
                sceneName = PrefsName.QuestionnaireSceneName;
                break;
            case SceneType.Menu:
                sceneName = PrefsName.MenuSceneName;
                break;
            default:
                break;
        }
        SceneManager.LoadScene(sceneName);
    }
}

[System.Serializable]
public enum SceneType{
    Start = 0,
    Questionnaire = 1,
    Menu = 2
}
