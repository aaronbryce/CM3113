using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BloodDestroyer2 : MonoBehaviour
{

    public static event Action BloodDestroy = delegate { };

    public GameObject splattertrigger;

    public ParticleSystem blood;

    public Animator toilet;

    bool wasInvoked1 = false;

    private void OnMouseDown()
    {
        if (!wasInvoked1)
        {
            wasInvoked1 = true;
            toilet.SetBool("isFlushed", true);
            BloodDestroy();
            Destroy(splattertrigger);
            foreach (var gameObj in GameObject.FindGameObjectsWithTag("DestroyableBlood2"))
            {
                Destroy(gameObj, 1);
            }
        }

    }
}

