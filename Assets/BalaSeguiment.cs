using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaSeguiment : MonoBehaviour
{
    public float m_Speed = 30;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * m_Speed;
    }
}
