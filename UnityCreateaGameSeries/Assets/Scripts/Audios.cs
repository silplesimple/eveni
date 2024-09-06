using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audios : MonoBehaviour
{
    AudioListener listener;

    public void Start()
    {
        
    }

    public void Setlistener()
    {
        AudioListener.ReferenceEquals(listener, this);
    }    
}


