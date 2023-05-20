using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoatScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("i exist");
        
    }

    // Update is called once per frame
    void Update()
    {
        /* float y = Mathf.Sin(2 * 0.5f * Mathf.PI + Mathf.PI / 2);
         float x = Mathf.Sin(0.5f * Mathf.PI + Mathf.PI / 2);
         transform.position += new Vector3(x, y) * Time.deltaTime;*/

        //transform.position = new Vector3(x ,y);
       // float movespeed = 0.0f;
        float y = Mathf.Sin(Time.time);
        transform.position = new Vector3(transform.position.x, 2* y);
        /*if (movespeed <= 0.1f)
        {
            movespeed++;
            transform.position = new Vector3(transform.position.x, transform.position.y + movespeed *Time.deltaTime);
        }
        else if (movespeed > 0.0f)
        {
            movespeed--;
            transform.position = new Vector3(transform.position.x, transform.position.y - movespeed *Time.deltaTime);
        }*/

    }

    
}
