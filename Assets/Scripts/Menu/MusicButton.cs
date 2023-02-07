using UnityEngine;
using UnityEngine.UI;
using System;

public class MusicButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Text _buttonName;


    public void Init(int index, string name, Action click)
    {
        _buttonName.text = name;
        _button.onClick.AddListener(delegate { click.Invoke(); });
    }
}
