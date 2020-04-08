using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuscarLletra : MonoBehaviour
{
   
    int numObj; //Variable numero objectes a buscar "random"
    public Text[] paraules; //Array d'objectes.text (nom)
    //public Text textParaula=null;
    public Text textLletra=null;
    string paraula;

    public static string nomBoto; //Nom objecte selecionat
    public int numObjectes; //Numero d'objectes
    int correctes = 0; //Acerts
    int error = 0;  //Errors
    int random; //numero random

    void Start()
    {
        random = Random.Range(0, numObjectes);  
        numObj = random;
        
        paraula=paraules[numObj].text;

        //text.unity paraula
        //textParaula.text =paraula;
        //text.unity lletra
        textLletra.text =paraula[0]+"";
        Debug.Log("Paraula: " + paraules[numObj].text);
        Debug.Log("Lletra a clicar: " + paraula[0]);

    }

    public void Test(Button button) {
        nomBoto = button.name;

        Debug.Log("Lletra clicada: " + nomBoto);

        if ( nomBoto[0] == paraula[0])
        {
            correctes++;
            Debug.Log("Correctes: " + correctes);
               
            do{
                random = Random.Range(0, numObjectes);
                numObj = random;
                Debug.Log("Paraula: " + paraules[numObj].text);
            }while(random!=numObj);

            paraula=paraules[numObj].text;

            //textParaula.text =paraula;
            textLletra.text =paraula[0]+"";
        }
        else
        {
                error++;
                Debug.Log("Errors: " + error);
                Debug.Log("Lletra a clicar: " + paraula[0]);
        }

    }
      
}

