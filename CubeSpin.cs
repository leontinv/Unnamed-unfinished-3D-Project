using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpin : MonoBehaviour
{
    public float spinx = 1f;
    public float spiny = 0f;
    public float spinz = 0f;
  
     void Update()
    {
        transform.Rotate(spinx, spiny, spinz);

        if (transform.rotation.x <= -1f)
            spinx += 0.5f;
        else if (transform.rotation.x >= 1f)
            spinx -= 0.5f;
    }
}
