using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorScript : MonoBehaviour
{
[MenuItem("Prefs/ClearAll")]    
public static void ClearPrefs(){
        PlayerPrefs.DeleteAll();
    }
}
