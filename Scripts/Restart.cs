using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private float HighScore=0;
    
    // Update is called once per frame
    void Update()
    {   
        if (PlayerScore.playerScore>HighScore){
            HighScore=PlayerScore.playerScore;
        }

        if(Input.GetKeyDown(KeyCode.R)){

            PlayerScore.playerScore=0;
            GameOver.isPlayerDead = false;
            Time.timeScale=1;

            SceneManager.LoadScene("SampleScene");
        }
    }
}
