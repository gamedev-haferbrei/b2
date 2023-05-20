using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoatScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
        float y = Mathf.Sin(Time.time);
        transform.position = new Vector3(transform.position.x, 2* y);
        

    }
   


}
