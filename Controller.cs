using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private float thrust = 15f;
    [SerializeField] private Rigidbody rb;


    
    private Vector2 lastPos;

    void Update()
    {
        Vector2 deltaPos = Vector2.zero;

        if(Input.GetMouseButton(0))
        {
            Vector2 currentPos = Input.mousePosition;

            if (lastPos == Vector2.zero)
                lastPos = currentPos;

            deltaPos = currentPos - lastPos;
            lastPos = currentPos;

            Vector3 force = new Vector3(deltaPos.x, 0, deltaPos.y) * thrust;
            rb.AddForce(force);
        }
        else

        {
            lastPos = Vector2.zero;
        }
    }
}
