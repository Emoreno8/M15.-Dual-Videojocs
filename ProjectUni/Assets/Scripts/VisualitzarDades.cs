using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualitzarDades : MonoBehaviour
{
    
    public string[] items;
    IEnumerator Start()
    {
        WWW itemsData = new WWW("http://localhost/unity/conectar.php");
        yield return itemsData;
        string itemsDataString = itemsData.text;
        print(itemsDataString);

        items = itemsDataString.Split(';');
        print(GetDataValue(items[0], "Nom"));
    }

    string GetDataValue(string Data, string index)
    {
        string value = Data.Substring(Data.IndexOf(index) + index.Length);
        if (value.Contains("|"))
        {
            value = value.Remove(value.IndexOf('|'));
        }
        return value;
    }
    
}
