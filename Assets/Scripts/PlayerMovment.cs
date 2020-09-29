using UnityEngine;

public class PlayerMovment : MonoBehaviour{
    //This is Prefrence To Rigidbody Component Called "rb"
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    // We Call it FixedUpdate Because 
    // We Are Using It To Mess W/ Physics
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime); //For Be Same in all Pc
        
        if(Input.GetKey("d") )
        {
            rb.AddForce(sideForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a") )
        {
            rb.AddForce(-sideForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
