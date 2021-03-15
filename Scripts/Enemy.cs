using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
  private Transform enemyHolder;
  public float speed;

  public GameObject shot;
  public Text winText;
  public float fireRate = .997f;
  void Start(){
    winText.enabled = false;
    InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
    enemyHolder = GetComponent<Transform> ();
  }

  void MoveEnemy()
  {
    enemyHolder.position += Vector3.right * speed;

    foreach (Transform enemy in enemyHolder){
      if(enemy.position.x < -5 || enemy.position.x > 5) { 
        speed = -speed;
        enemyHolder.position += Vector3.down * 0.5f; 
        return;
      }

      if(Random.Range(0f, 200f) < 1){
        Instantiate(shot, enemy.position, enemy.rotation);
      }

      if(enemy.position.y <=-4){
        GameOver.isPlayerDead = true;
        Time.timeScale=0;
      }
      if(enemyHolder.childCount==1){
        CancelInvoke();
        InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
      }
      if(enemyHolder.childCount==0){
        winText.enabled = true;
      }
    }
  }
}
