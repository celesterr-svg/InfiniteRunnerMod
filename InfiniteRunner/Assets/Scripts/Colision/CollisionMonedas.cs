using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class CollisionMonedas : MonoBehaviour
{
    public ScoreManager sM;
     private void Start()
    {
        if(sM == null)
        {
            sM = FindObjectOfType<ScoreManager>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            sM.Moneda();
            Destroy(gameObject);
        }
    }
}
