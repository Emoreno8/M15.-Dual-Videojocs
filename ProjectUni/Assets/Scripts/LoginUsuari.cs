using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginUsuari : MonoBehaviour
{
    public InputField inputNom;
    public InputField inputPass;

// Sortir de aplicacio
    public void Exit()
    {
        Application.Quit();
    }

    string inputName;
    string inputPasswordName;
    string loginURL = "http://ec2-18-210-22-233.compute-1.amazonaws.com/~wally/connectar.php";
    IEnumerator LoginToDB (string nom, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("Nom",nom);
        form.AddField("Password",password);
        WWW www = new WWW(loginURL,form);
        yield return www;
        Debug.Log("WWW:"+www.text);

        if(www.text.Contains("Admin")){
            SceneManager.LoadScene("Admin");
        }
        if(www.text.Contains("Login succes"))
        {
            SceneManager.LoadScene("Materia");
        }
        
    }

    public void Confirmar()
    {
        
        inputName = inputNom.text;
        inputPasswordName = inputPass.text;
        
        Debug.Log("nom:"+inputName);
        Debug.Log("Pas:"+inputPasswordName);

        StartCoroutine(LoginToDB(inputName, inputPasswordName));

        if(inputName==""){
            SceneManager.LoadScene("Materia");
        }
        if(inputName=="Admin"){
            SceneManager.LoadScene("Admin");
        }

    }

    /*
    public string inputName;
    public string inputPasswordName;
    string loginURL = "http://localhost/unity/conectar.php";

    IEnumerator LoginToDB (string username, string passwordname)
    {
        WWWForm form = new WWWForm();
        form.AddField("Nom",username);
        form.AddField("Password",passwordname);
        WWW www = new WWW(loginURL,form);
        yield return www;
        Debug.Log(www.text);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            StartCoroutine(LoginToDB(inputName, inputPasswordName));
        }
    }
    */

}
