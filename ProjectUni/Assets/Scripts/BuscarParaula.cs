using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuscarParaula : MonoBehaviour
{
    int numObj; //Variable numero objectes a buscar "random"
    //public Text[] paraules; //Array d'objectes.text (nom)
    public Text textParaula=null;
    public GameObject[] noms; //Array d'objectes amb el (nom)

    //public Text textLletra=null;
    string paraula;

    //correcte incorrecte
    public GameObject imatge1;
    public GameObject imatge2;

    private float temps = 0.0f; 
    private float tempsLimit = 1.0f; 


    public static string nomBoto; //Nom objecte selecionat
    public int numObjectes; //Numero d'objectes
    int correctes = 0; //Acerts
    int error = 0;  //Errors
    int random; //numero random


    void Start()
    {

        imatge1.SetActive(false);
        imatge2.SetActive(false);

        random = Random.Range(0, numObjectes); 
        numObj = random;
        
        paraula=noms[numObj].name;

        //text.unity paraula
        textParaula.text =paraula;
        //text.unity lletra
        //textLletra.text =paraula[0]+"";
        Debug.Log("Paraula: " + noms[numObj].name);
        Debug.Log("Lletra a clicar: " + paraula);

    }

    public void Aceptar(){


        if ( paraula[0] == nomBoto[0])
        {
            imatge1.SetActive(true);
            temps=0.0f;

            correctes++;
            Debug.Log("Correctes: " + correctes);
               
            do{
                random = Random.Range(0, numObjectes);
                numObj = random;
                Debug.Log("Paraula: " + noms[numObj].name);
            }while(random!=numObj);

            paraula=noms[numObj].name;
            
            textParaula.text =paraula;
            //textLletra.text =paraula[0]+"";
        }
        else
        {
                imatge2.SetActive(true);
                temps=0.0f;

                error++;
                Debug.Log("Errors: " + error);
                Debug.Log("Lletra a clicar: " + paraula[0]);
        }

    }

    public void Test(Button button) {
        nomBoto = button.name;

        Debug.Log("Lletra clicada: " + nomBoto);

    }

    public void Update(){

        temps = temps + 1 * Time.deltaTime;
        if(temps>=tempsLimit){
            imatge1.SetActive(false);
            imatge2.SetActive(false);
        }

    }
      
}

