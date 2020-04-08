using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuscarParelles : MonoBehaviour
{

    public List<GameObject> parellas; //Llista d objectes
    public int numObjectes; //Numero d'objectes

    int correctes = 0; //Acerts
    int error = 0; //Errors

    public static string nomBoto; //Nom objecte selecionat
    int numBoto; //
    string[] objNom = new string[2]; //Numero parelles selecionats
    int[] objNum = new int[2]; //Numero parelles selecionats

    int cont=0;

    void Start()
    {

        for(int i=0; i< numObjectes; i++)
        {
            parellas[i].SetActive(false); 
        }

    }

    public void Parella(Button button)
    {
        //nom boto selecionat
        nomBoto=button.name;
        //
        parellas.index;

        //primer objecte
        if(cont==0){
            for(int i=0; i< numObjectes; i++){
                if(parellas[i]==nomBoto){
                    objNum[0]=i;
                }      
            }
        }

        //segon objecte
        if(cont==1){

            for(int i=0; i< numObjectes; i++){
                if(parellas[i]==nomBoto){
                    objNum[1]=i;   
                }      
            }
        }

        for(int i=0; i< numObjectes; i++)
        {
            if(parellas[i].name==objNom[0] && parellas[i].name==objNom[1]){
                parellas[i].SetActive(false); 
            }
        }

        //activar
        Debug.Log(nomBoto);

        //primer objecte
        if(cont==0){
            objNum[cont]=nomBoto;
        }
        //segon objecte
        if(cont==1){
            objNum[cont]=nomBoto;
            //comparar 1 i 2 objecte
            if(objNum[0] != objNum[1]){
                //desactivar
                parella1[objNum[0]].SetActive(false);
                parella1[objNum[1]].SetActive(false);
                //reset
                cont=0;
                objName[0]="";
                objName[1]="";
            }else{
                //activar
                for (int i = 0; i <= numObjectes; i++)
                {
                    if(allObj[i].name==nomBoto)
                        allObj[i].SetActive(true);
                }
                //reset
                cont=0;
                objName[0]="";
                objName[1]="";
            }
            
        }

    }

}
