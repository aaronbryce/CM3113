using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SplatterScript : MonoBehaviour
{            
    public static event Action BloodSplat = delegate { };
    public static bool selected;
    public ParticleSystem Blood;
    bool splatter = false;

    void Start()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (splatter == false)
        {
            BloodSplat();
            Instantiate(this.Blood, transform.position, Quaternion.identity);
            splatter = true;
        }
        else { }

        

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
     
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       
    }



   
  

}
