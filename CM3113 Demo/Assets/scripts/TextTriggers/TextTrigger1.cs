using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger1 : MonoBehaviour
{
    public GameObject Text1;

    private void Start()
    {
        Text1.SetActive(false);
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        Text1.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Text1.SetActive(false);
    }



}
