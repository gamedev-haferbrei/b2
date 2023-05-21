using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlane : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Sprite[] frames;
    int frameIndex = 0;

    SpriteRenderer sr;
    Rigidbody2D rb;
    Transform xplayer;

    // Start is called before the first frame update
    void Start()
    {
        xplayer = player.GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(FlipSprite), 0f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FlipSprite()
    {
        frameIndex++;
        frameIndex %= frames.Length;
        sr.sprite = frames[frameIndex];
    }

    private void FixedUpdate()
    {
        
        if (Mathf.Abs(xplayer.position.x - rb.transform.position.x) <= 10 & rb.transform.position.y >= -5.5f) 
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.AddForce(new Vector2(-6,0)); 
        }
        else rb.constraints = RigidbodyConstraints2D.FreezeAll;
        
    }
}
