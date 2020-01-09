using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSeguiment : MonoBehaviour
{
    private GameObject enemy;
    public GameObject player;
    public float m_Speed = 10f;
    int contador = 0;
    private Vector3 enemy_player_dir;
    // Start is called before the first frame update
    void Start()
    {
      enemy = GameObject.FindGameObjectWithTag("Player");

      transform.LookAt(enemy.transform.position);
      Transform fill = this.gameObject.transform.GetChild(0);
      fill.transform.Rotate(0,90,0);
     enemy_player_dir = (enemy.transform.position - this.transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
      transform.position += enemy_player_dir * Time.deltaTime * m_Speed;
      contador++;
      if(contador >= 180){
        Destroy(this.gameObject);
      }
    }
}
