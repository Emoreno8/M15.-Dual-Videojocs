using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuscarColors : MonoBehaviour
{
   
    int numObj; //Variable numero objectes a buscar "random"
    
    public List<GameObject> colors;//={"GRIS","ROSA","GROC","LILA","BLAU","MARRO","TARONJA","VERD"};
    public Text textColor;
    string color;
    
    public static string nomBoto; //Nom objecte selecionat
    public int numObjectes; //Numero d'objectes
    int correctes = 0; //Acerts
    int error = 0;  //Errors
    int random; //numero random

    //corecte incorrecte
    public GameObject imatge1;   
    public GameObject imatge2; 

    private float temps = 0.0f; 
    private float tempsLimit = 1.0f; 



    void Start()
    {
        imatge1.SetActive(false);
        imatge2.SetActive(false);


        random = Random.Range(0, numObjectes);  
        numObj = random;

        //Debug.Log("NumeroRandom: " + random);

        color=colors[numObj].name;

        textColor.text =color;
        Debug.Log("Color a clicar: " + colors[numObj].name);

    }

    public void Aceptar(Button button) {

        if ( nomBoto == colors[numObj].name)
        {
            imatge1.SetActive(true);
            temps=0.0f;

            correctes++;
            Debug.Log("Color clicat: " + nomBoto);
            Debug.Log("Correctes: " + correctes);
               
            do{
                random = Random.Range(0, numObjectes);
                numObj = random;
                Debug.Log("Color a clicar: " + colors[numObj].name);
            }while(random!=numObj);

            color=colors[numObj].name;
            textColor.text =color;

        }
        else
        {
                imatge2.SetActive(true);
                temps=0.0f;

                error++;
                Debug.Log("Errors: " + error);
        }

    }

    public void Test(Button button) {
        nomBoto = button.name;
        
        Debug.Log("Color a clicar: " + colors[numObj]);
        Debug.Log("Color clicat: " + nomBoto);


    }

    public void Update(){

        temps = temps + 1 * Time.deltaTime;
        if(temps>=tempsLimit){
            imatge1.SetActive(false);
            imatge2.SetActive(false);
        }

    }
      
}

