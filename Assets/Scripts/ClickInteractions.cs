using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInteractions : MonoBehaviour
{
    [SerializeField] public Transform cloneFood;
    [SerializeField] int foodValue;

    FinishRequest finishRequest;
    LogicScript logicScript;

    // Start is called before the first frame update
    void Start()
    {
        finishRequest = GameObject.FindGameObjectWithTag("Logic").GetComponent<FinishRequest>();
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "Food")
        {
            Instantiate(cloneFood, new Vector3(-1.94f, 1.65f, -8.083f), cloneFood.rotation);
            finishRequest.resetPlate = false;
        }

        logicScript.plateValue += foodValue; //Pega o valor do prato (inicialmente 0) e adiciona o valor atual + o valor do ingrediente
        Debug.Log(logicScript.plateValue + "  " + logicScript.requestValue);
    }
}
