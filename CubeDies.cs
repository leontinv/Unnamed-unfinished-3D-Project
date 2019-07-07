using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDies : MonoBehaviour
{
    public GameObject cube;
    private bool spin = false;
   
    void OnTriggerEnter(Collider cube)
    {
        if (cube.CompareTag("light"))
        {
            Destroy(gameObject, 0.35f);
            spin = true;
            SliderAdd.sliderValue.value += 1f;
            
        }
    }

    void Update()
    {
        if(spin)
        {
            transform.Rotate(0f, 2.5f, 0f);
            transform.Translate(0f, 0.1f, 0f, Space.World);
            transform.localScale -= new Vector3(0.05F, 0.05F, 0.05F);
        }
        

     
        
    }
}
