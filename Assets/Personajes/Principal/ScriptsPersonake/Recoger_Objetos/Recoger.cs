using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoger : MonoBehaviour
{
    public GameObject objeto;
    public GameObject picked;
    public Transform zone, shieldZone;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (objeto != null && objeto.GetComponent<Objeto>().isPickable == true && picked == null && objeto.GetComponent<Objeto>().tag == "sword")
        {
            if (Input.GetKey(KeyCode.F))
            {
                picked = objeto;
                picked.GetComponent<Objeto>().isPickable = false;
                picked.transform.SetParent(zone);
                picked.transform.position = zone.position;
                picked.transform.rotation = zone.rotation;
                picked.GetComponent<Rigidbody>().useGravity = false;
                picked.GetComponent<Rigidbody>().isKinematic = true;
                picked.transform.Rotate(0, 0, 0);

                anim.SetBool("Espada", true);

            }
            
        }
        else if (picked != null && objeto.GetComponent<Objeto>().tag == "sword")
        {
            if (Input.GetKey(KeyCode.G))
            {

                picked.transform.Rotate(0, 0, 0);
                picked.GetComponent<Objeto>().isPickable = true;
                picked.transform.SetParent(null);
                picked.GetComponent<Rigidbody>().useGravity = true;
                picked.GetComponent<Rigidbody>().isKinematic = false;
                picked = null;

                anim.SetBool("Espada", false);
            }
        }


        if (objeto != null && objeto.GetComponent<Objeto>().isPickable == true && picked == null && objeto.GetComponent<Objeto>().tag=="escudo")
        {
            if (Input.GetKey(KeyCode.F))
            {
                picked = objeto;
                picked.GetComponent<Objeto>().isPickable = false;
                picked.GetComponent<BoxCollider>().isTrigger = true;
                picked.transform.SetParent(shieldZone);
                picked.transform.position = shieldZone.position;
                picked.transform.rotation = shieldZone.rotation;
                picked.GetComponent<Rigidbody>().useGravity = false;
                picked.GetComponent<Rigidbody>().isKinematic = true;
                picked.transform.Rotate(0, 0, 0);

                anim.SetBool("escudo", true);

            }
        }
        else if (picked != null && objeto.GetComponent<Objeto>().tag == "escudo")
        {
            if (Input.GetKey(KeyCode.G))
            {
               
                

                picked.transform.Rotate(0, 0, 0);
                picked.GetComponent<Objeto>().isPickable = true;
                picked.transform.SetParent(null);
                picked.GetComponent<Rigidbody>().useGravity = true;
                picked.GetComponent<Rigidbody>().isKinematic = false;
                picked = null;

                anim.SetBool("escudo", false);

            }
        }
    }


}
