using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painzone : MonoBehaviour
{
    public int Damage = 5;

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("Collison");

        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<Health>() == true)
            {
                other.gameObject.GetComponent<Health>().TakeDamage(Damage);
            }
        }

    }

}

