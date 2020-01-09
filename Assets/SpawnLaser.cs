using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLaser : MonoBehaviour
{
    public static float seconds = 0;
    private GameObject enemy;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    void Update()
    {
      seconds += Time.deltaTime;
        if(seconds >= 2f){
          GameObject instance = Instantiate(Resources.Load("Laser 1", typeof(GameObject)),
            this.transform.position,transform.rotation)
            as GameObject;
          seconds = 0f;
        }

    }
}
