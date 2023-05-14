using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject playerGO;

    float initialX;

    // Start is called before the first frame update
    void Start()
    {
        initialX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void LateUpdate()
    {
        transform.position = new Vector3(playerGO.transform.position.x + initialX, transform.position.y, transform.position.z);
    }
}
