using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BloodDestroyer5 : MonoBehaviour
{
    public static event Action BloodDestroy = delegate { };

    public GameObject splattertrigger;

    public ParticleSystem blood;

    public Animator kitchensink;

    bool wasInvoked1 = false;

    private void OnMouseDown()
    {
        if (!wasInvoked1)
        {
            wasInvoked1 = true;
            kitchensink.SetBool("isFlushed", true);
            BloodDestroy();
            Destroy(splattertrigger);
            foreach (var gameObj in GameObject.FindGameObjectsWithTag("DestroyableBlood5"))
            {
                Destroy(gameObj, 1);
            }
        }

    }
}