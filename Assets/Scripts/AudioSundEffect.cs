using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSundEffect : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioClip jump,dead,musicBackground;
    void Start()
    {
        musicBackground1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void musicBackground1(){
        audioSource.clip = musicBackground;
        audioSource.Play();
        
    }

    public void musicJump1(){
        audioSource.clip = jump;
        audioSource.Play();
    }
      public void musicDead(){
        audioSource.clip = dead;
        audioSource.Play();
    }
}
