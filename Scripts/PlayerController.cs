using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform Player;
    public float speed;
    public float maxBoundary, minBoundary;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    
    private float nextFire;
    // Start is called before the first frame update
    void Start()
    {
     Player = GetComponent<Transform> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float b = Input.GetAxis ("Horizontal");

        if(Player.position.x < minBoundary && b < 0)
         b=0;
        else if(Player.position.x > maxBoundary && b>0)
         b=0;

        Player.position += Vector3.right*b*speed;
    }

    void Update(){
        if(Input.GetButton("Fire1") && Time.time > nextFire){
            nextFire = Time.time + fireRate;
            Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}
