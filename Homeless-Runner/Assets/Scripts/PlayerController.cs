
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    //Veriables
    public float speed = 10;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 1.6f;
    //Bounds Range
    //public float xRange = 3.9f;

    public bool isOnGround = true;
    public float jumpForce;

    public bool gameOver = false;


    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    
    //Fixed update allows for palyer to move forward every 5 units per seconds giving better performance and smootness
    //Constant forward movements for runner
    private void FixedUpdate (){     
    Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;

    //Horizontal movement while keeping speed and forward projection
    //horizontalMulti allowing to move faster horizontaly compared to forward
    Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
    rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {


    //     //Keep Player In bounds
	// if (transform.position.x < -xRange)
	// {
	// 	transform.position = new Vector3(-xRange, transform.position.x, transform.position.z);
	// }

	// if (transform.position.x > xRange)
	// {
	// 	transform.position = new Vector3(xRange, transform.position.x, transform.position.z);
	// }

    //Side movements left/right
    horizontalInput = Input.GetAxis("Horizontal");

    //jumping with spacebar
    if (Input.GetKeyDown(KeyCode.Space) && isOnGround) {
         rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse) ;
        // isOnGround = false; 
        } 
    }

    // private void OnCollisionEnter(Collision collision) 
    // {
    //     isOnGround = true; 
    // }


    //Check if player runs into obstecle and if on ground then gives gameover message
    private void OnCollisionEnter(Collision collision)
    {
     if (collision.gameObject.CompareTag("Ground")) {
         isOnGround = true;
         } 
             else if (collision.gameObject.CompareTag("Obstacle" )) {
             gameOver = true;
             Debug.Log("Game Over!"); } 
             else if (collision.gameObject.CompareTag("Obs1" )) {
             gameOver = true;
             Debug.Log("Game Over!"); } 
             else if (collision.gameObject.CompareTag("Obs2" )) {
             gameOver = true;
             Debug.Log("Game Over!"); } 

    }

    

}
