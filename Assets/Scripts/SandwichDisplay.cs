using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SandwichDisplay : MonoBehaviour
{
    public List<Sandwich>sandwichList = new List<Sandwich>();    

    public Text sandwichNameText;
    public Image sandwichImage;
    public Text sandwichIngredient_1;
    public Text sandwichIngredient_2;
    public Text sandwichIngredient_3;

    public int _sandwichValue; //Passando o valor do prato para esse script

    RandomizerNumber randomizerNumber;
    LogicScript logicScript;


    // Start is called before the first frame update
    void Start()
    {
        randomizerNumber = GameObject.FindGameObjectWithTag("Logic").GetComponent<RandomizerNumber>(); //Pegando um numero aleatorio da lista
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        SetSandwich();
    }

    void Update()
    {
        SetSandwich();
    }

    void SetSandwich()
    {
        sandwichNameText.text = sandwichList[randomizerNumber.sandwichChosen].sandwichName;
        sandwichImage.sprite = sandwichList[randomizerNumber.sandwichChosen].sandwichIcon;
        sandwichIngredient_1.text = sandwichList[randomizerNumber.sandwichChosen].sandwichIngredient1;
        sandwichIngredient_2.text = sandwichList[randomizerNumber.sandwichChosen].sandwichIngredient2;
        sandwichIngredient_3.text = sandwichList[randomizerNumber.sandwichChosen].sandwichIngredient3;

        _sandwichValue = sandwichList[randomizerNumber.sandwichChosen].sandwichValue;

        SetValueSandwich();
    }

    void SetValueSandwich()
    {
        logicScript.requestValue = _sandwichValue;
    }

}
