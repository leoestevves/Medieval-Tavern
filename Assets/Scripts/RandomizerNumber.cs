using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizerNumber : MonoBehaviour
{
    public int randomNumber;
    public int sandwichChosen;


    // Start is called before the first frame update
    void Start()
    {
        Randomizer();
    }
        

    public void Randomizer() //Gerando um n�mero aleat�rio, esse n�mero vai definir qual item da minha lista ser� chamado
    {
        randomNumber = Random.Range(0, 4); //N�mero de sanduiches feitos (no caso pega de 0 at� 3, ent�o s�o 4)
        sandwichChosen = randomNumber;
    }


    
}
