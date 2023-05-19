using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
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


        // col.gameObject.GetComponent<Player>().SetFuel(col.fuel + 30);
        //Destroy(col.gameObject);
        Debug.Log("trigger happened");
        
    }
}
