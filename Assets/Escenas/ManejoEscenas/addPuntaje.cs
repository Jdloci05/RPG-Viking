using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPuntaje : MonoBehaviour
{
    public int ScoreX = 20;

    private void OnDestroy()
    {
        Puntaje.Score += ScoreX;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
