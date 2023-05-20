using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraffeScript : MonoBehaviour
{
    //float t = 0.0f;
    /*void Position()
    {
        while (t < 5.0f)
        {
            transform.position = new Vector3(0.5f * (transform.position.x - t) * Time.deltaTime, transform.position.y);
            t++;
        }
    }*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = 5- (5*  Mathf.Sin(Time.time));
        transform.position = new Vector3(2 * x, transform.position.y );

    }
    /*void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit");

        //Player must fall here
    }*/
}
