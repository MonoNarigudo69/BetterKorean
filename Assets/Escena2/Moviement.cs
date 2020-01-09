using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviement : MonoBehaviour
{

    public float rotation = 5;

    void Update()
    {
          RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotation );
    }
}
