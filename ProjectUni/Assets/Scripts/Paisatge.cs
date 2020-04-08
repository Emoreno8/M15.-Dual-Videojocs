using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Paisatge : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Inici":
                SceneManager.LoadScene("Inici");
                break;
            case "Materia":
                SceneManager.LoadScene("Materia");
                break; 
            case "Menu":
                SceneManager.LoadScene("Menu");
                break;
            case "Platja":
                SceneManager.LoadScene("Platja");
                break;
            case "Montanya":
                SceneManager.LoadScene("Montanya");
                break;
            case "FonsMari":
                SceneManager.LoadScene("FonsMari");
                break;
            case "Granja":
                SceneManager.LoadScene("Granja");
                break;
            case "Desert":
                SceneManager.LoadScene("Desert");
                break;
            case "Musica":
                SceneManager.LoadScene("Musica");
                break;
            case "Musica0":
                SceneManager.LoadScene("Musica0");
                break;
            case "Musica1":
                SceneManager.LoadScene("Musica1");
                break;
            case "Musica2":
                SceneManager.LoadScene("Musica2");
                break;
            case "Musica3":
                SceneManager.LoadScene("Musica3");
                break;
            case "Plastica":
                SceneManager.LoadScene("Plastica");
                break;
            case "Plastica0":
                SceneManager.LoadScene("Plastica0");
                break;
            case "Plastica1":
                SceneManager.LoadScene("Plastica1");
                break;
            case "Plastica2":
                SceneManager.LoadScene("Plastica2");
                break;
            case "Llengua":
                SceneManager.LoadScene("Llengua");
                break;
            case "Llengua0":
                SceneManager.LoadScene("Llengua0");
                break;
            case "Llengua1":
                SceneManager.LoadScene("Llengua1");
                break;
            case "Mates":
                SceneManager.LoadScene("Mates");
                break;
            case "Mates0":
                SceneManager.LoadScene("Mates0");
                break;
            case "Mates1":
                SceneManager.LoadScene("Mates1");
                break;
            case "Visual":
                SceneManager.LoadScene("Visual");
                break;
            case "Visual0":
                SceneManager.LoadScene("Visual0");
                break;
        }
    }

}
