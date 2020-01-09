using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobleSalt : MonoBehaviour
{
    public float jumpHeight;
    public bool isGrounded;
    private Rigidbody rb;
    public bool volant = false;
    private int numJumps = 0;

    public float thrust;
    public float fallMultiplayer = 2f;
    public float lowJumpMultiplayer = 2f;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpHeight = 10f;
    }


    void Update()
    {
        if (Input.GetButton("Jump") && isGrounded)
        {
            rb.velocity = Vector3.up * jumpHeight;
            numJumps++;
        }
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplayer - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplayer - 1) * Time.deltaTime;
        }
        rb.AddForce(Vector3.up * thrust);


        if (Input.GetButtonDown("Jump") && volant == true)
        {
            rb.velocity = Vector3.up * jumpHeight;
            volant = false;
  
        }
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplayer - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplayer - 1) * Time.deltaTime;
        }
        rb.AddForce(Vector3.up * thrust);


    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
          numJumps = 0;
            isGrounded = true;
            volant = false;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
            volant = true;

        }
    }
  }
