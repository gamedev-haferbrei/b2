using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Sprite[] frames;
    int frameIndex = 0;

    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;

    [SerializeField] float boostSpeed;
    [SerializeField] float fuelPenalty;
    [SerializeField] AudioManager audioManager;

    public float fuel;

    public void SetFuel(float value)
    {
        fuel = Mathf.Clamp01(value);
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating(nameof(FlipSprite), 0f, 0.1f);
        
        rb.velocity = new Vector2(2, 0);
    }
    
    void FixedUpdate()
    {
        //transform.rotation;
        
        if (Input.GetKey(KeyCode.Space))
        {
            if (fuel > 0)
            {
                rb.AddForce(new Vector2(0, boostSpeed));
                transform.Rotate(new Vector3(0, 0, 25) * Time.deltaTime); // = Quaternion.Euler(0, 0, 25);
            }
            SetFuel(fuel - fuelPenalty);
            
        }
        else
        {
            //transform.rotation = Quaternion.identity;
            transform.Rotate(new Vector3(0, 0, -10) * Time.deltaTime);
            //transform.rotation = Quaternion.Euler(0, 0, -10);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        audioManager.PlayAudio();
    }

    void FlipSprite()
    {
        frameIndex++;
        frameIndex %= frames.Length;
        spriteRenderer.sprite = frames[frameIndex];
    }
}
