using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteFood : MonoBehaviour
{
    FinishRequest finishRequest;
    private void Start()
    {
        finishRequest = GameObject.FindGameObjectWithTag("Logic").GetComponent<FinishRequest>(); //Pegando o script de l�gica
    }

    private void Update()
    {
        if (finishRequest.resetPlate == true) //Clicando no bot�o "Pr�ximo" o resetPlate se torna true, destruindo tudo que est� no prato
        {
            Destroy(gameObject);            
        }        
    }
}
