using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class VelocidadObstaculos : MonoBehaviour
{
    [Header("Obstaculos")]
    public ObstaculosMovimiento[] objects;
    

    public float baseSpeed = 5f;

    private float timer = 0;
    private float speedMultiplier = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed();
        updateSpeed();
    }

    void speed()
    {
        timer += (Time.deltaTime);

        speedMultiplier = Mathf.Clamp(timer, 10, 200);
    }
    void updateSpeed()
    {
        for (int i = 0; i < objects.Length; i++) {
            objects[i].moveSpeed = (float)(baseSpeed * (speedMultiplier * 0.1)); ;
        }
    }
}
