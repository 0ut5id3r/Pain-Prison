using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pBite : MonoBehaviour
{
    public int biteDamage = 5;

    void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Collison");

        if (collision.gameObject.tag == "Enemy")
        {
            if (collision.gameObject.GetComponent<Health>() == true)
            {
                collision.gameObject.GetComponent<Health>().TakeDamage(biteDamage);
            }
        }

    }

}


