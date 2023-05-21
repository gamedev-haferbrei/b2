using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] Transform fireballTF;
    [SerializeField] float rotationSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireballTF.RotateAround(transform.position, Vector3.forward, rotationSpeed);
    }
}
