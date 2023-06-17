using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Sandwich", menuName = "Sandwich/New Sandwich")]
public class Sandwich : ScriptableObject
{
    public string sandwichName;
    public Sprite sandwichIcon;

    public string sandwichIngredient1;
    public string sandwichIngredient2;
    public string sandwichIngredient3;

    public int sandwichValue; //Valor utilizado para fazer a compara��o se o prato est� certo ou errado
}
