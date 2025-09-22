using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float rotationSpeed = 2f;
    void Start()
    {
        
    }

    
    void Update()
    {
        gameObject.transform.Rotate(0f, 0f, rotationSpeed, Space.Self);
    }
}
