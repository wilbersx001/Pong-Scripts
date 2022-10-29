using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteRaqueta2 : MonoBehaviour
{
    // Start is called before the first frame update
   public float desplazamientoHorizontal;
   public float velocidad = 20.0f;

   void Update()
   {
      if(transform.position.x < 956)
      {
        transform.position = new Vector3(956, transform.position.y, transform.position.z);
       
      }

      
      if(transform.position.x > 1008)
      {
        transform.position = new Vector3(1008, transform.position.y, transform.position.z);
      }

      desplazamientoHorizontal = Input.GetAxis("Horizontal");
      transform.Translate(Vector3.right * desplazamientoHorizontal * Time.deltaTime);
      
   }
}
