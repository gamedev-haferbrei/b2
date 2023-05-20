using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    //Player player = gameObject.GetComponent<Player>();
    [SerializeField] Player player;
    [SerializeField] AudioSource item;
    [SerializeField] AudioClip SFXItem;
    // [SerializeField] GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        //currentItem = GetComponent<star_gold>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //colType = col.GetType;
        // playerType = player.GetType;
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Collider")
        {
            item.PlayOneShot(SFXItem, 1.0f);
            player.SetFuel(player.fuel + 30);
            Debug.Log("trigger happened player");
            Destroy(gameObject);
        }
            
        
        // col.gameObject.GetComponent<Player>().SetFuel(col.fuel + 30);
        //Destroy(col.gameObject);
        //Player player = col.gameObject.GetComponent<Player>();


    }
}
