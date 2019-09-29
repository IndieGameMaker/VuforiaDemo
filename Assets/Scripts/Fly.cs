using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public Animation butterfly;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("TIGER"))
        {
            butterfly.enabled = true;
        }
        else
        {
            butterfly.enabled = false;
        }
    }
}
