using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    
    bool hasPackage;
    [SerializeField] float destroyDuration = 0.5f;

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("OUCH!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("You picked up the package!");
            hasPackage = true;
            Destroy(other.gameObject, destroyDuration); // remove package from scene once picked up.
        }

        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered!");
            hasPackage = false; // reset to false so can't keep delivering same package over and over again.
        }

    }

}
