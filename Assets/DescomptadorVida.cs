using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescomptadorVida : MonoBehaviour
{
    public Text vides;
    int vides2 = 100;


    void OnTriggerEnter(Collider other){

      if (other.gameObject.tag == "Bala")
      {
        print(vides2);
        vides2--;
        vides.text = "Vides: " + vides2;
        print("BalaMorta");
        Destroy(other.gameObject);
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", 0.7f, "time", 0.3f));
        }
      if (vides2 == 0){
        Application.LoadLevel("Boss1Win");
      }
    }
}
