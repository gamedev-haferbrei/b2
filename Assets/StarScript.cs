using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    //Player player = gameObject.GetComponent<Player>();
    [SerializeField] Player player;
    
    // [SerializeField] GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        //currentItem = GetComponent<star_gold>();
        //gameObject.tag = "Star";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //colType = col.GetType;
        // playerType = player.GetType;
        //Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Collider")
        {
            
            player.SetFuel(player.fuel + 30);
            Destroy(gameObject);
        }
            
        
        // col.gameObject.GetComponent<Player>().SetFuel(col.fuel + 30);
        //Destroy(col.gameObject);
        //Player player = col.gameObject.GetComponent<Player>();


    }
}
