using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BloodDestroyer : MonoBehaviour
{

    public static event Action BloodDestroy = delegate { };
   
    public GameObject splattertrigger;

    public ParticleSystem blood;

    public Animator fishbowl;

    bool wasInvoked1 = false;

    private void OnMouseDown()
    {
            if (!wasInvoked1)
            {
                wasInvoked1 = true;
                fishbowl.SetBool("isBroken", true);
                BloodDestroy();
                Destroy(splattertrigger);
                foreach (var gameObj in GameObject.FindGameObjectsWithTag("DestroyableBlood"))
                {
                    Destroy(gameObj, 1);
                }
            }
        
    }
}


