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
    [SerializeField] private InputField _inputField;
    private string _newText;
    private string _filePath;

    private void Start()
    {
        _filePath = Path.Combine(Application.persistentDataPath, PrefsName.DiaryFileName);
        Debug.Log(_filePath);

        _text.text = ReadTextFromFile(_filePath);
    }


    public void ChangeText(string text){
        _newText = text;
    }

    public void Apply(){
        AddedDiaryLine(_newText);
        _text.text = ReadTextFromFile(_filePath);
        ClearInputField();
    }

    public void Cansel(){
        ClearInputField();
    }

    private void ClearInputField(){
        _inputField.Select();
        _inputField.text = "";
        _newText = "";
    }



    private void AddedDiaryLine(string text)
    {
        string path = Path.Combine(Application.persistentDataPath, PrefsName.DiaryFileName);

        AddedTextToFile(path, $"\n{GetCurrentData()} {text}");
    }


    private string GetCurrentData() => $"[{String.Format("{0:g}", DateTime.Now)}]";

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
        using (StreamWriter sw = new StreamWriter(path, true))
            sw.WriteLine(text);
    }
}
