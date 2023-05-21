using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRock : MonoBehaviour
{
    [SerializeField] private float offset;

    float i = 0;
    float y;
    
    // Start is called before the first frame update
    void Start()
    {
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Sin(i+offset*Mathf.PI/180) + y, 0);
        i += Mathf.PI / 180;
    }
}
