using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteFood : MonoBehaviour
{
    FinishRequest finishRequest;
    private void Start()
    {
        finishRequest = GameObject.FindGameObjectWithTag("Logic").GetComponent<FinishRequest>(); //Pegando o script de lógica
    }

    private void Update()
    {
        if (finishRequest.resetPlate == true) //Clicando no botão "Próximo" o resetPlate se torna true, destruindo tudo que está no prato
        {
            Destroy(gameObject);            
        }        
    }
}
