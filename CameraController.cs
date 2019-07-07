using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
        void FixedUpdate()
    {
        transform.position = transform.position + Vector3.forward * 1 * Time.fixedDeltaTime;
    }
}
