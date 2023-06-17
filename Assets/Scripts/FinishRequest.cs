using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRequest : MonoBehaviour
{
    public bool resetPlate = false; //bool usada para saber quando o prato pode ser resetado

    LogicScript logicScript;

    // Start is called before the first frame update
    void Start()
    {
       logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RequestFinished()
    {
        if (logicScript.requestValue == logicScript.plateValue)
        {
            logicScript.addScore(1);
            Debug.Log("Prato certo!");
        }
        else
        {
            logicScript.removeScore(1);
            Debug.Log("Prato errado!");
        }

        ResetTable();        
    }
    
    void ResetTable()
    {
        resetPlate = true;
        logicScript.plateValue = 0000000; //Resetando a lógica de comparação entre o prato feito e o prato pedido
    }

}
