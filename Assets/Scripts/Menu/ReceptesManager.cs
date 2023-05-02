using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceptesManager : MonoBehaviour
{
    [SerializeField] private ReceptButton _receptButtonPrefab;
    [SerializeField] private Transform _buttonsParrent;
    [Space(12)]
    [SerializeField] private GameObject _receptManagerWindow;
    [SerializeField] private GameObject _showWindow;
    [Space(12)]
    [SerializeField] private Recept[] _recepts;
    [SerializeField] private Text _showtext;

    private void Start(){
        for(int i = 0; i < _recepts.Length; i++){
            var recept = _recepts[i];
            Instantiate(_receptButtonPrefab, _buttonsParrent).Init(this, i, recept.sprite, recept.name);
        }
    }

    public void ButtonClick(int index){
        if(index >= _recepts.Length){
            Debug.LogError($"Индекс {index} не найден в массиве _recepts");
            return;
        }
        
        _showtext.text = _recepts[index].description;
        _showWindow.SetActive(true);
        _receptManagerWindow.SetActive(false);
    }
}

[System.Serializable]
public struct Recept{
    public string name;
    public Sprite sprite;
    [TextAreaAttribute] public string description;
}
