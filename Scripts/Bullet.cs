using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    private Transform bullet;
  public float Speed;
    // Start is called before the first frame update
    void Start()
    {
      bullet = GetComponent< Transform> ();
    }

    void FixedUpdate(){
      bullet.position += Vector3.up *Speed;

      if(bullet.position.y >= 10)
        Destroy (gameObject);
    }
  
    void OnTriggerEnter2D(Collider2D other){
      if(other.tag == "Enemy"){
        Destroy (other.gameObject);
        Destroy (gameObject);
        PlayerScore.playerScore+=10;
      }      
      if(other.tag == "Enemy2"){
        Destroy (other.gameObject);
        Destroy (gameObject);
        PlayerScore.playerScore+=20;
      }
      if(other.tag == "Enemy3"){
        Destroy (other.gameObject);
        Destroy (gameObject);
        PlayerScore.playerScore+=30;
      }
      if(other.tag == "Enemy4"){
        Destroy (other.gameObject);
        Destroy (gameObject);
        PlayerScore.playerScore+=40;
      }
      else if (other.tag =="Base")
       Destroy (gameObject);
    }
}
