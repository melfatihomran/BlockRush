using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public MeshRenderer mr;
    public float Fforce = 200; // F here indicates the direction Forward
    public float Sforce = 300; // S here indicates the direction Sideways
    public float SuperSpeed = 2000;
    public bool SS = false;



    // Start is called before the first frame update
    void Start()
    {
      
       // rb.AddForce(0, 150, 300);
    }

    // Update is called once per frame
    // FixedUpdate instead of just update beacuse im dealing with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Fforce * Time.deltaTime); //Adds a constant amount of force on the z-Axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(Sforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Sforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1 )
        {
            FindObjectOfType<Game_MANG>().EndGame();
        }
        if(rb.position.y > 5)
        {
            mr.enabled = false;

        }
        if (rb.position.y < 5)
        {
            mr.enabled = true;

        }
        if( rb.position.z > 100)
        {
            SS = true;
        }
        else {
            SS = false;
        }
        if ( SS == true)
        {
            Fforce = SuperSpeed;
        }

    }
}
