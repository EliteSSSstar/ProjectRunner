using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collisions : MonoBehaviour
{

    public bool gameOver = false;

    public bool isOnGround = true;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

       //Check if player runs into obstecle and if on ground then gives gameover message
    private void OnCollisionEnter(Collision collision)
    {
     if (collision.gameObject.CompareTag("Ground")) {
         isOnGround = true;
         } 
             else if (collision.gameObject.CompareTag("Obstacle" )) {
                
                 Debug.Log("Oops");
                  } 
             else if (collision.gameObject.CompareTag("Obs1" )) 
             {
                
                Debug.Log("Ouch!!"); 
             } 
             else if (collision.gameObject.CompareTag("Obs2" )) {
            
             Debug.Log("UnBlessed"); } 
             else if (collision.gameObject.CompareTag("Obs3" )) {
             //Spawn Power up 
             
             Debug.Log("Watch Out!!"); } 

    }
}
