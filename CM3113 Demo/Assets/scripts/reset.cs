using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    void Start()
    {
        Invoke("Transition", 3);

    }

    void Transition()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
