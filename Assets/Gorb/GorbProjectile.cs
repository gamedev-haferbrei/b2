using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GorbProjectile : MonoBehaviour
{
    int lastVisibleFrame;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SpriteRenderer>().isVisible)
        {
            lastVisibleFrame = Time.frameCount; 
        }
        if (Time.frameCount - lastVisibleFrame >= 60) Destroy(gameObject);
    }
}
