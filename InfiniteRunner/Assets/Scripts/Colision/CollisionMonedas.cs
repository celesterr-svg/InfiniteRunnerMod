using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class CollisionMonedas : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            scoreManager.Moneda();
            Destroy(gameObject);
        }
    }
}
