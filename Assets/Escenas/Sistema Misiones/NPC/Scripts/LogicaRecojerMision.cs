using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaRecojerMision : MonoBehaviour
{
    public LogicaNPC logicaNPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {

        logicaNPC.numDeEnemigos--;


    }

}
