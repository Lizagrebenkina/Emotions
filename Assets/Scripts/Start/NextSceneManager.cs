using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneManager : MonoBehaviour
{
    public void LoadNextScene(){
        if(PlayerPrefs.HasKey(PrefsName.QuestionnaireComplete)) SceneManager.LoadScene(PrefsName.MenuSceneName);
        else SceneManager.LoadScene(PrefsName.QuestionnaireSceneName);
    }
}
