using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutscene : MonoBehaviour
{
    void Start()
    {
        Invoke("Transition", 7);
        
    }

    void Transition()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
