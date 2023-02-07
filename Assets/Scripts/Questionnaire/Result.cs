using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    [SerializeField] private VarResult[] _vars;

    public string GetValue(int mood){
        for(int i = 0; i < _vars.Length; i++){
            var range = _vars[i].range;
            if(mood >= range.x && mood < range.y)
                return _vars[i].value;
        }
        return $"Совпадений с {mood} не найдено";
    }
}


[System.Serializable]
public class VarResult{
    public string value;
    public Vector2Int range;
}
