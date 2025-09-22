using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArribaAbajo : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float moveDownSpeed = 5f;
    public float variation = 2.5f;

    private bool up = true;
    private bool down = false;

    private float yPosition;
    private float startingHeight;
    private Vector3 vector = new();

    private void Start()
    {
        vector = transform.position;
        startingHeight = vector.y;
    }
    void Update()
    {
        vector = transform.position;
        yPosition = vector.y;
        

        if (up == true)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }

        if (down == true) 
        {
            transform.position += Vector3.down * moveDownSpeed * Time.deltaTime;
        }


        if (yPosition >= (startingHeight + variation))
        {
            up = false;

            down = true;
        }

        if(yPosition <= (startingHeight - variation))
        {
            up = true;

            down = false;
        }
    }    
}
