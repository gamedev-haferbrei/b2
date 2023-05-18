using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // [SpecializeField] AudioSource source;
    [SerializeField] public AudioSource source;
    [SerializeField] public AudioClip jumpSound;
   // [SerializeField] public AudioSource background;
    // Start is called before the first frame update
    // [SerializeField] GameObject audioManagerGO;
    // AudioManager audioManager;
   // AudioClip currentClip = null;


    public void PlayAudio()
    {
        // source.clip = BellSound;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.PlayOneShot(jumpSound, 0.75f);
        }
        //source.PlayOneShot(jumpSound, 0.75f);
    }

    /*public void PlayBackground(AudioClip clip)
    {

        if (clip != currentClip)
        {
            background.clip = clip;
            background.Play();
            currentClip = clip;
        }

    }*/

    public void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }


}

