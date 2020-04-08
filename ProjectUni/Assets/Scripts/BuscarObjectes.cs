using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BuscarObjectes : MonoBehaviour
{
    int numAnimal; //Variable numero animal a buscar "random"
    
    public List<GameObject> animalBuscar; //Llista d animals/objectes
    public List<GameObject> animals; //Llista d animals/objectes

    public static string nomBoto; //Nom de animal selecionat
    
    public int numObjectes; //Numero d'objectes/animals

    int correctes = 0; //Acerts
    int error = 0;  //Errors

    int random; //numero random

    void Start()
    {
        
        random = Random.Range(0, numObjectes);  
        numAnimal = random;

        Debug.Log("NumeroRandom: " + random);

        for(int i=0; i< numObjectes; i++)
        {
            animalBuscar[i].SetActive(false);
        }

        animalBuscar[numAnimal].SetActive(true);
        
    }

    public void Test(Button button) {
        nomBoto = button.name;

    Debug.Log("Animal que tenies que clicar: " + animalBuscar[numAnimal].name);

        if ( nomBoto == animalBuscar[numAnimal].name)
        {
            correctes++;
            Debug.Log("Animal clicat: " + nomBoto);
            Debug.Log("Correctes: " + correctes);
               
            do{
                random = Random.Range(0, numObjectes);
                Debug.Log("NumeroRandom: " + random);
                numAnimal = random;
            }while(random!=numAnimal);

            for (int i = 0; i < numObjectes; i++)
            {
                animalBuscar[i].SetActive(false);
            }

            animalBuscar[numAnimal].SetActive(true);

        }
        else
        {
                error++;
                Debug.Log("Errors: " + error);
        }



    }

    
}
