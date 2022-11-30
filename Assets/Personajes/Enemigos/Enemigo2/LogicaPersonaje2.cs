using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje2 : MonoBehaviour
{
    public int hp;
    public int dañoArma;
    public vidaPlayer vidaPlayer;
    public int dañoPuño;
    public Animator anim;
    public float x, y;

    public int rutina;
    public float cronometro;
    public Quaternion angulo;
    public float grado;

    public bool atacando;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("sinVida", false);
        target = GameObject.Find("personajePrincipal (1)");
    }

    // Update is called once per frame
    void Update()
    {
        
        Comportamiento_Enemigo();

    }
    void movimientoPersonaje()
    {

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "sword")
        {
            if (anim != null)
            {
                anim.Play("IMPACTO");
            }
            hp -= dañoArma;

        }


        if (other.gameObject.tag == "puño")
        {
            if (anim != null)
            {
                anim.Play("IMPACTO");
            }

            hp -= dañoPuño;
        }
        if (hp <= 0)
        {
            //Destroy(gameObject); //animacion que hace al llegar a 0 de vida
            anim.SetBool("sinVida", true);
        }

    }

    public void Comportamiento_Enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 5)
        {
            anim.SetBool("run", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }
            switch (rutina)
            {
                case 0:
                    anim.SetBool("walk", false);
                    break;

                case 1:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                    transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                    anim.SetBool("walk", true);
                    break;

            }
        }
        else
        {
            if (Vector3.Distance(transform.position, target.transform.position) > 1 && !atacando)
            {
                var lookPos = target.transform.position - transform.position;
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
                anim.SetBool("walk", false);

                anim.SetBool("run", true);
                transform.Translate(Vector3.forward * 2 * Time.deltaTime);

                anim.SetBool("attack", false);
            }
            else
            {
                anim.SetBool("walk", false);
                anim.SetBool("run", false);
                if (vidaPlayer.vidaActual <= 0)
                {
                    anim.SetBool("attack", false);
                    atacando = false;
                }
                else
                {
                    anim.SetBool("attack", true);
                    atacando = true;
                }
               
            }
        }

    }
    public void Final_Ani()
    {
        anim.SetBool("attack", false);
        atacando = false;
    }

    public void DesactivarObjeto()
    {
        Destroy(gameObject);
    }
}
