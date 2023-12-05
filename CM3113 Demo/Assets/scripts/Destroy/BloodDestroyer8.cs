using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BloodDestroyer8 : MonoBehaviour
{
    public static event Action BloodDestroy = delegate { };

    public GameObject splattertrigger;

    public ParticleSystem blood;

    public Animator drip;

    bool wasInvoked1 = false;

    private void OnMouseDown()
    {
        if (!wasInvoked1)
        {
            wasInvoked1 = true;
            drip.SetBool("isFlushed", true);
            BloodDestroy();
            Destroy(splattertrigger);
            foreach (var gameObj in GameObject.FindGameObjectsWithTag("DestroyableBlood8"))
            {
                Destroy(gameObj, 1);
            }
        }

    }
}
