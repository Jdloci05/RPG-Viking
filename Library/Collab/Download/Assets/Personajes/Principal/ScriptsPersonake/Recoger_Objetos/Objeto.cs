using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    public bool isPickable = true;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "zone")
        {
            other.GetComponentInParent<Recoger>().objeto = this.gameObject;
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "zone")
        {
            other.GetComponentInParent<Recoger>().objeto = null;
        }
    }
}
