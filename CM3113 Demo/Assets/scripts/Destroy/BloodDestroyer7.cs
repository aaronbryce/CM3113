using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BloodDestroyer7 : MonoBehaviour
{
    public static event Action BloodDestroy = delegate { };

    public GameObject splattertrigger;

    public ParticleSystem blood;

    public Animator table;

    bool wasInvoked1 = false;

    private void OnMouseDown()
    {
        if (!wasInvoked1)
        {
            wasInvoked1 = true;
            table.SetBool("isFlushed", true);
            BloodDestroy();
            Destroy(splattertrigger);
            foreach (var gameObj in GameObject.FindGameObjectsWithTag("DestroyableBlood7"))
            {
                Destroy(gameObj, 1);
            }
        }

    }
}
