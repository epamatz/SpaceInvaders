using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{   
    public static bool isPlayerDead = false;
    private Text gameOver;
    // Start is called before the first frame update
    void Start()
    {
     gameOver = GetComponent<Text>();
     gameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

     if(isPlayerDead){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
         Time.timeScale=0;
         gameOver.enabled = true;
     }
    }
}
