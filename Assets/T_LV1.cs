using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_LV1 : MonoBehaviour
{
    public GameObject camera;
    private Rigidbody rb;
    public GameObject move;
    bool control = false;
    public int a = 0 ;
    float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
      movementSpeed = 7f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
      if (other.gameObject.tag == "Trigger_dead_boss1")
      {
        transform.position = new Vector3(0.25f, -4.94f, -0.13f);
        }
        if (other.gameObject.tag == "Saltalboss")
        {
           Application.LoadLevel("Boss1");
          }
        if (other.gameObject.tag == "Pinxo_boss")
        {
          transform.position = new Vector3(0.25f, -4.94f, -0.13f);
          }

        if (other.gameObject.tag == "Primercheckpoint")
        {
          transform.position = new Vector3(1.82f, 4.25f, -0.13f);
        }

        if (other.gameObject.tag == "Segoncheckpoint"){
          transform.position = new Vector3(34.3f, 7.77f, 0.06f);
        }
        if (other.gameObject.tag == "Laser"){
          Application.LoadLevel("Boss1");
        }

        if (other.gameObject.tag == "T_LV2")
        {
          camera.transform.position = new Vector3(50.85f, 1.89f, -18.33f);
        }
        if (other.gameObject.tag == "Pinxo"){
          transform.position = new Vector3(34.3f, 7.77f, 0.06f);
          rb.useGravity = false;
        }

        if(other.gameObject.tag == "Ground" && other.gameObject.name == "Moviment"){
        transform.parent = other.transform;
    }
  }

    void OnCollisionExit(Collision other){
      if(other.gameObject.tag == "Ground" && other.gameObject.name == "Moviment"){
              transform.parent = null;

          }
        }
    }
