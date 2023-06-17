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
        

    public void Randomizer() //Gerando um número aleatório, esse número vai definir qual item da minha lista será chamado
    {
        randomNumber = Random.Range(0, 4); //Número de sanduiches feitos (no caso pega de 0 até 3, então são 4)
        sandwichChosen = randomNumber;
    }


    
}
