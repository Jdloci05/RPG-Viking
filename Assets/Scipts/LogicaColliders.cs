using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaColliders : MonoBehaviour
{
    public BoxCollider[] armasBoxCol;
    public BoxCollider pu�oBoxCol;
    private Animator anim;
    public LogicaPersonaje1 logicaPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        DesactivarCollidersArmas();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivarCollidersArmas()
    {
        for(int i =0; i < armasBoxCol.Length; i++)
        {
            if (anim.GetBool("Espada") == true)
            {
                if(armasBoxCol[i] != null)
                {
                    armasBoxCol[i].enabled = true;
                }
            }
            else
            {
                pu�oBoxCol.enabled = true;
            }
        }
    }

    public void DesactivarCollidersArmas()
    {
        for (int i = 0; i < armasBoxCol.Length; i++)
        {
            if (armasBoxCol[i] != null)
            {
                armasBoxCol[i].enabled = false;
            }
        }
        pu�oBoxCol.enabled = false;
    }
}
