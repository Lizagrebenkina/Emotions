using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceptButton : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Text _nameText;
    private ReceptesManager _manager;
    private int _index = 0;

    public void Init(ReceptesManager manager, int index, Sprite sprite, string name){
        _manager = manager;
        _index = index;
        _image.sprite = sprite;
        _nameText.text = name;
    }

    public void Click(){
        _manager.ButtonClick(_index);
    }
}
