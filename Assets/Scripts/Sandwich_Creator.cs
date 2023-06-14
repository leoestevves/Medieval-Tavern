using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Sandwich", menuName = "Sandwich/New Sandwich")]
public class Sandwich_Creator : ScriptableObject
{
    [SerializeField] string sandwichName;
    [SerializeField] Sprite sandwichIcon;

    [SerializeField] string firstIngredient;
    [SerializeField] string secondIngredient;
    [SerializeField] string thirdIngredient;


}
