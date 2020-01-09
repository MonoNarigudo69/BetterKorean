using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour {

  public GameObject player;
  float movementSpeed;
  int i = 0;
	// Use this for initialization
	void Start () {
    movementSpeed = 0.01f;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
      dash();
		}
	}


  void dash(){

    while(i <= 200){
      transform.Translate(Vector3.right * movementSpeed);
      transform.localScale = new Vector3(0.3f,0.3f,0.3f);
      i++;
    }
    transform.Translate(Vector3.left * movementSpeed);
    transform.localScale = new Vector3(0.6f,0.6f,0.6f);
    i = 0;

  }
}
