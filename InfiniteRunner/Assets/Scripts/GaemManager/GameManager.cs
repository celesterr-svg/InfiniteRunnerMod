using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
   static public bool gameOver = false;
    public int totalCoins = 0;
    public GameObject Panel;
    void Awake()
    {
       
    }

    private void Update()
    {
        if (gameOver== true)
        {
            Panel.SetActive(true);
            Time.timeScale = 0f;
            
            if (Input.GetKeyDown(KeyCode.R)) 
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reinicia la escena
                Time.timeScale = 1f;
                gameOver = false;
            }
            
        }
       
    }


}