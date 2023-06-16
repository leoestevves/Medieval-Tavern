using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Sandwich", menuName = "Sandwich/New Sandwich")]
public class Sandwich : ScriptableObject
{
    [SerializeField] string sandwichName;
    [SerializeField] Sprite sandwichIcon;

    [SerializeField] string sandwichIngredient1;
    [SerializeField] string sandwichIngredient2;
    [SerializeField] string sandwichIngredient3;

    [SerializeField] int sandwichValue;
}
