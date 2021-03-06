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
      else if (other.tag =="Base")
       Destroy (gameObject);
    }
}
