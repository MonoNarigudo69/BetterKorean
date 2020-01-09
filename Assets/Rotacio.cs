using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacio : MonoBehaviour
{
  int i = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if(i < 120){
        transform.Rotate(0,0,0.5f);}
        if(i > 240){
            transform.Rotate(0,0,-0.5f);
        }
        if(i > 360){
          i = 0;
        }

    }
}
