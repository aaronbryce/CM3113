using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class ScoreDown : MonoBehaviour
{
    [SerializeField] PointHub pointHUD;
    private Text pointText;

    private void Awake()
    {
        BloodDestroyer.BloodDestroy += RunCo;
        BloodDestroyer2.BloodDestroy += RunCo;
        BloodDestroyer3.BloodDestroy += RunCo;
        BloodDestroyer4.BloodDestroy += RunCo;
        BloodDestroyer5.BloodDestroy += RunCo;
        BloodDestroyer6.BloodDestroy += RunCo;
        BloodDestroyer7.BloodDestroy += RunCo;
        BloodDestroyer8.BloodDestroy += RunCo;
        pointText = GetComponent<Text>();
    }

    void Start()
    {
        pointHUD.Points = 0;
    }

    private IEnumerator CountPoints()
    {
        pointHUD.Points -= 2;

        yield return new WaitForEndOfFrame();

    }

    public void RunCo()
    {
        StartCoroutine(CountPoints());
    }

    private void OnDestroy()
    {
        BloodDestroyer.BloodDestroy -= RunCo;
        BloodDestroyer2.BloodDestroy -= RunCo;
        BloodDestroyer3.BloodDestroy -= RunCo;
        BloodDestroyer4.BloodDestroy -= RunCo;
        BloodDestroyer5.BloodDestroy -= RunCo;
        BloodDestroyer6.BloodDestroy -= RunCo;
        BloodDestroyer7.BloodDestroy -= RunCo;
        BloodDestroyer8.BloodDestroy -= RunCo;
    }
}