using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectesMusica : MonoBehaviour
{

    int numObj; //Variable numero objectes a buscar "random"
    public List<GameObject> songs;
    public List<GameObject> instruments;

    public static string nomBoto; //Nom objecte selecionat
    public int numObjectes; //Numero d'objectes/animals
    int correctes = 0; //Acerts
    int error = 0;  //Errors
    int random; //numero random

    void Start()
    {

        random = Random.Range(0, numObjectes);  
        numObj = random;

        Debug.Log("NumeroRandom: " + instruments[numObj].name);

        for(int i=0; i< numObjectes; i++)
        {
            instruments[i].SetActive(false);
        }

        instruments[numObj].SetActive(true);
    }

    public void Aceptar() {

        if ( nomBoto == instruments[numObj].name)
        {
            correctes++;
            Debug.Log("Correctes: " + correctes);
               
            do{
                random = Random.Range(0, numObjectes);
                Debug.Log("NumeroRandom: " + instruments[numObj].name);
                numObj = random;
            }while(random!=numObj);
                

            for (int i = 0; i < numObjectes; i++)
            {
                instruments[i].SetActive(false);
            }

            instruments[numObj].SetActive(true);

        }
        else
        {
                error++;
                Debug.Log("Errors: " + error);
        }


    }

    public void Test(Button button) {
        nomBoto = button.name;

        Debug.Log("Clip clicat: " + nomBoto);
        Debug.Log("Clip que tenies que clicar: " + instruments[numObj].name);

    }

}
