using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    //L�gica para compara��o entre prato feito e prato pedido
    [Header("L�gica pedidos")]
    public int plateValue = 0000000;
    public int requestValue;

    //Score
    [Header("Score")]
    public int playerScore;
    public Text textScore;

    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        textScore.text = playerScore.ToString();
    }

    public void removeScore(int scoreToRemove)
    {
        playerScore = playerScore - scoreToRemove;
        textScore.text = playerScore.ToString();
    }
   
}