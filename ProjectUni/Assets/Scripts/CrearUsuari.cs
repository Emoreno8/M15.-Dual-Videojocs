using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CrearUsuari : MonoBehaviour
{
    
    string crearUsuariUrl = "http://ec2-18-210-22-233.compute-1.amazonaws.com/~wally/crear_usuari.php";
    public InputField inputNomNou;
    string inputPassNou ="";

    public void CrearUsu (string nom, string password)
    {
        WWWForm from = new WWWForm();

        from.AddField("Nom", nom);
        from.AddField("Password", password);

        WWW www = new WWW(crearUsuariUrl, from);

        Debug.Log("Usuari: "+ nom + " creat");

    }

    public void Crear(){

        CrearUsu(inputNomNou.text, inputPassNou);

    }
    
   
}
