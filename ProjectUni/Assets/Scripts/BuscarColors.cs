using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuscarColors : MonoBehaviour
{
   
    int numObj; //Variable numero objectes a buscar "random"
    
    string[] colors={"GRIS","ROSA","GROC","LILA","BLAU","MARRO","TARONJA","VERD"};
    public Text textColor;
    string color;
    
    public static string nomBoto; //Nom objecte selecionat
    int numObjectes=8; //Numero d'objectes
    int correctes = 0; //Acerts
    int error = 0;  //Errors
    int random; //numero random

    void Start()
    {
        random = Random.Range(0, numObjectes);  
        numObj = random;

        //Debug.Log("NumeroRandom: " + random);
        
        color=colors[numObj];
        textColor.text =color;
        Debug.Log("Color a clicar: " + colors[numObj]);
    }

    public void Test(Button button) {
        nomBoto = button.name;
        
        Debug.Log("Color a clicar: " + colors[numObj]);
        Debug.Log("Color clicat: " + nomBoto);

        if ( nomBoto == colors[numObj])
        {
            correctes++;
            Debug.Log("Color clicat: " + nomBoto);
            Debug.Log("Correctes: " + correctes);
               
            do{
                random = Random.Range(0, numObjectes);
                numObj = random;
                Debug.Log("Color a clicar: " + colors[numObj]);
            }while(random!=numObj);

            color=colors[numObj];
            textColor.text =color;

        }
        else
        {
                error++;
                Debug.Log("Errors: " + error);
        }

    }
      
}

