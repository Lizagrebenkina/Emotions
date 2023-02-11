using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class DiaryPanel : MonoBehaviour
{
    //отображать ранее введенный текст

    //при нажатии на кнопку добавить текст отображать поле для ввода и кнопки "отменить/принять"
    //при нажатии отменить закрывать поле для ввода и кнопки
    //при нажатии принять дописывать текст

    [SerializeField] private Text _text;

    private void Start()
    {
        string path = Path.Combine(Application.persistentDataPath, PrefsName.DiaryFileName);

        Debug.Log(path);

        _text.text = ReadTextFromFile(path);
    }


    private string GetCurrentData(){
        String.Format("{0:g}", DateTime.Now);
    }
    
        private string ReadTextFromFile(string path)
        {
            string text = "";

        if (System.IO.File.Exists(path) == false) AddedTextToFile(path, "");

        using (StreamReader sr = new StreamReader(path))
            text = sr.ReadToEnd();

        return text;
    }
    private void AddedTextToFile(string path, string text)
    {
        using (StreamWriter sw = new StreamWriter(path))
            sw.WriteLine(text);
    }
}
