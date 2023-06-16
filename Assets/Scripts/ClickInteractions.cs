using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInteractions : MonoBehaviour
{
    [SerializeField] public Transform cloneFood;
    [SerializeField] int foodValue;

    FinishRequest finishRequest;
    // Start is called before the first frame update
    void Start()
    {
        finishRequest = GameObject.FindGameObjectWithTag("Logic").GetComponent<FinishRequest>();
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

        LogicScript.plateValue += foodValue; //Pega o valor do prato (inicialmente 0) e adiciona o valor atual + o valor do ingrediente
        Debug.Log(LogicScript.plateValue + "  " + LogicScript.requestValue);
    }
}
