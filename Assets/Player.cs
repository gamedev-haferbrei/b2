using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] Sprite[] frames;
    int frameIndex = 0;

    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;

    [SerializeField] float boostSpeed;
    [SerializeField] float fuelPenalty;
    [SerializeField] AudioManager audioManager;
    [SerializeField] AudioSource crashSource;
    [SerializeField] AudioClip SFXHit;
    [SerializeField] AudioSource item;
    [SerializeField] AudioClip SFXItem;
    [SerializeField] TextMeshProUGUI restart;
    //[SerializeField] GameObject star;

    public float fuel;
    public bool isAlive;
    public float timer;
    public bool isTimer = false;

    public void SetFuel(float value)
    {
        fuel = Mathf.Clamp01(value);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Player";
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        isAlive = true;

        InvokeRepeating(nameof(FlipSprite), 0f, 0.1f);
    }
    
    void FixedUpdate()
    {

        //https://docs.unity3d.com/ScriptReference/Rigidbody.MovePosition.html
        //Vector3 m_Input = new Vector3(1f, 0f, 0f);
        //rb.MovePosition(transform.position + m_Input * Time.deltaTime);
        if (isAlive)
        {
            rb.AddForce(new Vector2(10, -boostSpeed / 2));
            if (Input.GetKey(KeyCode.Space))
            {
                if (fuel > 0)
                {
                    rb.AddForce(new Vector2(0, boostSpeed));
                    // transform.Rotate(new Vector3(0, 0, 25));
                    transform.rotation = Quaternion.Euler(0, 0, 25);
                }
                SetFuel(fuel - fuelPenalty);

            }
            else
            {
                //transform.Rotate(new Vector3(0, 0, -10));
                transform.rotation = Quaternion.Euler(0, 0, -10);
            }
        }
        else
        {   
            
            rb.AddForce(new Vector2(rb.velocity.x, rb.velocity.y));
            if (Input.GetKey(KeyCode.Space) & timer >= 2)
            {
                isTimer = false;
                restart.gameObject.SetActive(false);
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
            else
            {
                //transform.Rotate(new Vector3(0, 0, -10));
                transform.rotation = Quaternion.Euler(0, 0, -10);
            }
        }


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag("Ceiling"))
        {
            if (isAlive)
            {
                crashSource.PlayOneShot(SFXHit, 0.75f);
                rb.gravityScale = 1;
                rb.mass = 0.3f;
                isAlive = false;
                isTimer = true;
                rb.gameObject.layer = 8;
                gameObject.GetComponentInChildren<CapsuleCollider2D>().gameObject.layer = 8;
            }

            rb.AddForce(new Vector2(Random.Range(-4, 4), 3), ForceMode2D.Impulse);

        }
    }

    // Update is called once per frame
    void Update()
    {
        audioManager.PlayAudio();
        if (isTimer) timer += Time.deltaTime;
        if (timer>=2) restart.gameObject.SetActive(true);
    }

    void FlipSprite()
    {
        frameIndex++;
        frameIndex %= frames.Length;
        spriteRenderer.sprite = frames[frameIndex];
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //colType = col.GetType;
        // playerType = player.GetType;
        //Debug.Log(col.gameObject.name);
        if (col.gameObject.CompareTag("Star"))
        {
            item.PlayOneShot(SFXItem, 1.0f);
            SetFuel(fuel + 30);
            Destroy(col.gameObject);
        } else if (col.gameObject.CompareTag("Level End Trigger"))
        {
            SceneManager.LoadScene("Menu");
        }


        // col.gameObject.GetComponent<Player>().SetFuel(col.fuel + 30);
        //Destroy(col.gameObject);
        //Player player = col.gameObject.GetComponent<Player>();


    }
}
