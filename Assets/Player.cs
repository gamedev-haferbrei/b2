using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Sprite[] frames;
    int frameIndex = 0;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

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
        spriteRenderer.sprite = frames[frameIndex];
    }
}
