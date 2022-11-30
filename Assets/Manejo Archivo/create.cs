using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class create : MonoBehaviour
{

    public string puntajeS;
    public int puntosLoad;


    // Start is called before the first frame update

    private void Awake()
    {
        cargar();
    }
    public void Guardar()
    {
        StreamWriter file = new StreamWriter("Assets/Manejo Archivo/datos.txt");
        puntajeS = Puntaje.Score.ToString();
        file.WriteLine(puntajeS);
        file.Flush();
        file.Close();
    }

    public void cargar()
    {
        StreamReader file = new StreamReader("Assets/Manejo Archivo/datos.txt");

        string text = file.ReadLine();
        puntosLoad = int.Parse(text);

        Puntaje.Score = puntosLoad;
    }

    public void limpiar()
    {
        StreamWriter file = new StreamWriter("Assets/Manejo Archivo/datos.txt");
        
        file.WriteLine("");
        file.Flush();
        file.Close();
    }
}
