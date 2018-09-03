using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    public static Audio instance;

    private void Start()
    {
        instance = this;
    }

    public AudioClip LoadAudio(string audioName)
    {
        return Resources.Load("DisProject/Audios/" + audioName) as AudioClip;
    }
}
