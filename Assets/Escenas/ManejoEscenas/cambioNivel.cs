using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class cambioNivel : MonoBehaviour
{

    public string nombreE;
    private int puntosLoad;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(nombreE);
            StreamReader file = new StreamReader("Assets/Manejo Archivo/datos.txt");

            string text = file.ReadLine();
            puntosLoad = int.Parse(text);

            Puntaje.Score = puntosLoad;
        }
    }
}
