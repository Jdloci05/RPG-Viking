using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaBarra : MonoBehaviour
{
    private Animation ani;
    public void LoadScene(string nombreE)
    {
        SceneManager.LoadScene(nombreE);
        ani = GetComponent<Animation>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ani.Play("Averrr");
    }

    // Update is called once per frame
    
}
