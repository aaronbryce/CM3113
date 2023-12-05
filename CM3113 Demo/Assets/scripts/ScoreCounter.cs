using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] PointHub pointHUD;
    private Text pointText;

    public GameObject player;
    public ParticleSystem Blood;

    private void Awake()
    {
        SplatterScript.BloodSplat += RunCo;
        pointText = GetComponent<Text>();
    }

    void Start()
    {
        pointHUD.Points = 0;
    }

    void Update()
    {
        if (pointHUD.Points > 60) 
        {
            Destroy(player);
            Instantiate(this.Blood, transform.position, Quaternion.identity);
            Invoke("Transition", 2);
        }
    }

    void Transition()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    private IEnumerator CountPoints()
    {
            pointHUD.Points += 2;

            yield return new WaitForEndOfFrame();
        
    }
    
    public void RunCo()
    {
        StartCoroutine(CountPoints());
    }

    private void OnDestroy()
    {
        SplatterScript.BloodSplat -= RunCo;
    }
}