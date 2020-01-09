using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public float movementSpeed;
    void Start()
    {
        movementSpeed = 7;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey("a"))
      {
        transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
      }
      if (Input.GetKey("d"))
      {
        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
      }

      if (Input.GetButtonDown("Fire2"))
      {
        GameObject instance = Instantiate(Resources.Load("Cube (3)", typeof(GameObject)),
        this.transform.position,transform.rotation)
        as GameObject;
          }
      }
    }
