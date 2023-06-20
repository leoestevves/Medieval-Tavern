using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInteractions : MonoBehaviour
{
    public Transform cloneFood;
    [SerializeField] int foodValue;

    FinishRequest finishRequest;
    LogicScript logicScript;
    UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        finishRequest = GameObject.FindGameObjectWithTag("Logic").GetComponent<FinishRequest>();
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        uiManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (uiManager.gameIsActive == true)
        {
            if (gameObject.tag == "Food")
            {
                Instantiate(cloneFood, new Vector3(-2.05f, 1.65f, -8.083f), cloneFood.rotation); // Posi��o que vai spawnar os ingredientes
                finishRequest.resetPlate = false;
            }

            logicScript.plateValue += foodValue; //Pega o valor do prato (inicialmente 0) e adiciona o valor atual + o valor do ingrediente
            //Debug.Log(logicScript.plateValue + "  " + logicScript.requestValue);
        }        
    }
}
