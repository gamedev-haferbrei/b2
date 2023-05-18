using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    [SerializeField] AudioSource crashSource;
    [SerializeField] AudioClip SFXHit;

    void OnCollisionEnter2D(Collision2D col)
    {
        crashSource.PlayOneShot(SFXHit, 0.75f);
        //Player must fall here
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
