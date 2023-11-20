
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    //Veriables
    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 1.6f;


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

        //Side movements left/right
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
