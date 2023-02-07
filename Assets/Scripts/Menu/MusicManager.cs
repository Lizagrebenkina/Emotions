using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private Music[] _musics;

    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private MusicButton _musicButtonPrefab;
    [SerializeField] private Transform _buttonParrent;

    private void Start(){
        for(int i = 0; i < _musics.Length; i++){
            Instantiate(_musicButtonPrefab, _buttonParrent).Init(i, _musics[i],name, () => {PlayClip(i);});
        }
    }


    public void PlayClip(int index){

    }
}

[System.Serializable]
public struct Music{
    public string name;
    public AudioClip audio;
}
