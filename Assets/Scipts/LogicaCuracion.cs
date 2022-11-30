using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaCuracion : MonoBehaviour
{
    public vidaPlayer vida;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if(vida.vidaActual < 100)
        {
            vida.vidaActual += 4 * Time.deltaTime;
        }
        else
        {
            vida.vidaActual = 100;
            vida.vidaActual += 0;
        }
        
    }
}
