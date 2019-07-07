using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject ufolight;

    void OnTriggerEnter(Collider light)
    {
        if(light.CompareTag("enemycube"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
