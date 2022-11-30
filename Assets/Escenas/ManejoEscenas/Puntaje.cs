using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public static int Score = 0;
    public string ScoreString = "Score";

    public Text TextScore;

    public static Puntaje puntaje;

    private void Awake()
    {
        puntaje = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TextScore != null)
        {
            TextScore.text = ScoreString+Score.ToString();
        }
    }
}
