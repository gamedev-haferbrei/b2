using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Sprite[] frames;
    int frameIndex = 0;

    SpriteRenderer spriteRenderer;

    public float fuel;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        InvokeRepeating(nameof(FlipSprite), 0f, 0.1f);

        GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FlipSprite()
    {
        frameIndex++;
        frameIndex %= frames.Length;
        spriteRenderer.sprite = frames[frameIndex];
    }
}
