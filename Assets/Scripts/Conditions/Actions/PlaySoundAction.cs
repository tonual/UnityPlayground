using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
[AddComponentMenu("Playground/Actions/PlaySound")]
public class PlaySoundAction : Action {
            
    public override bool ExecuteAction(GameObject dataObject) {        

        AudioSource audioSource = GetComponent<AudioSource>();        
        audioSource.Play();
        return true;
    }
}

