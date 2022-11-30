using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManejoEscenas : MonoBehaviour
{
   
    // Start is called before the first frame update
 

    public void LoadScene(string nombreE)
    {
        SceneManager.LoadScene(nombreE);

    }

  public void salirJuego()
    {
        Application.Quit();
    }

    public void cargarObjeto(GameObject objeto)
    {
        objeto.SetActive(true);
    }
    public void desactivarObjeto(GameObject objeto)
    {
        objeto.SetActive(false);
    }
    public void Pausar()
    {
        Time.timeScale = 0;
    }
    public void Reanudar()
    {
        Time.timeScale = 1;
    }
}
