using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavalamp : MonoBehaviour
{
    public Animator lamp;

    private void OnMouseDown()
    {
        lamp.SetBool("isFlushed", true);
    }

}
