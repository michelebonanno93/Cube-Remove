using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource source;
    static AudioSource staticSource;

    public void Start(){
        staticSource = source;
    }


   public static void PlaySound(string clipName){
        AudioClip clip = Resources.Load<AudioClip>("Clips/"+clipName);
        staticSource.PlayOneShot(clip);

   }
}
