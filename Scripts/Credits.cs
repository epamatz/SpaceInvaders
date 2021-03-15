using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
 
 public float targetTime = 5.0f;

 void Update(){
 
 targetTime -= Time.deltaTime;
 
 if (targetTime <= 0.0f)
 {
    timerEnded();
 }

 }
 
 void timerEnded()
 {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
 }
}
