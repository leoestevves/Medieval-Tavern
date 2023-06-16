using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRequest : MonoBehaviour
{
    public bool resetPlate = false; //bool usada para saber quando o prato pode ser resetado

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RequestFinished()
    {
        if (LogicScript.requestValue == LogicScript.plateValue)
        {
            Debug.Log("Prato certo!");
        }
        else
        {
            Debug.Log("Prato errado!");
        }

        resetPlate = true;
        
    }    

}
