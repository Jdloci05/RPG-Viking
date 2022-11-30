using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class ultimoNivel : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombreE;
    private int puntosLoad;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(nombreE);
            StreamWriter file = new StreamWriter("Assets/Manejo Archivo/datos.txt");

            file.WriteLine("0");
            file.Flush();
            file.Close();
        }
    }
}
