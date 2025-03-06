using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculosMovimiento : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento
    public float destroyXPosition = -10f; // Punto donde el obstáculo se destruye

    void Update()
    {
        // Mueve el obstáculo hacia la izquierda
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Destruye el obstáculo cuando sale de la pantalla
        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}