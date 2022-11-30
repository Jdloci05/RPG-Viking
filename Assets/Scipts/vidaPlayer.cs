using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaPlayer : MonoBehaviour
{
    public int vidaMax;
    public float vidaActual;
    public Image barraDeVida;
    public Animator anim;
    
    void Start()
    {
        vidaActual = vidaMax;
        anim = GetComponent<Animator>();
        
    }
    // Update is called once per frame
    void Update()
    {
        RevisarVida();
        
        if(vidaActual <= 0)
        {
            
            //gameObject.SetActive(false);//animacion de morir
            anim.SetBool("sinVida", true);
        }
        
    }

    public void RevisarVida()
    {
        barraDeVida.fillAmount = vidaActual / vidaMax;
    }

}
