using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    private float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.gameOver)
        {
            score += Time.deltaTime * 10; // Incrementa la puntuación con el tiempo
            scoreTxt.text = "Score: " + Mathf.FloorToInt(score);
        }
    }

    //Ahora las monedas dan puntuacion al ser tocadas
    public void Moneda()
    {
        score = score + 100;
    }
}
