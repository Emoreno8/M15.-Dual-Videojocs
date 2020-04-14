using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuscarParelles : MonoBehaviour
{
    [SerializeField]
    private Transform puzzleField;

    [SerializeField]
    private GameObject btn;

    void Awake()
    {
        
        for(int i=0; i<8; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(puzzleField, false);
        }

    }

}


/*    
    GameObject token; //imatge tocada
    List<int> faceindexes = new List<int> {0,1,2,3,0,1,2,3}; //llista de imatges
    public static System.Random rnd = new System.Random(); //llistar imatges random
    public int shuffleNum = 0; //imatge comparar
    int[] visibleFaces = { -1, -2 }; //imatges correctes

    void Start() //inici
    {
        int originalLength = faceindexes.Count; //llargada, numero de imatges original 
        float yPosition = 2.3f;
        float xPosition = -2.2f;
        
        for(int i=0; i < 7; i++)
        {
            shuffleNum = rnd.Next(0,(faceindexes.Count));
            var temp = Instantiate(token, new Vector3(xPosition, yPosition, 0),Quaternion.identity);
            temp.GetComponent<MainCard>().faceIndex = faceindexes[shuffleNum];
            faceindexes.Remove(faceindexes[shuffleNum]);
            xPosition = xPosition +4;
            if(i == (originalLength/2 - 2))
            {
                yPosition = -2.3f;
                xPosition = -6.2f;
            }
        }
        token.GetComponent<MainCard>().faceIndex = faceindexes[0];

    }

    public bool TwoCardsUp() //comparar cartes girades
    {
        bool cardUp=false; 
        if(visibleFaces[0] >= 0 && visibleFaces[1] >= 0)
        {
            cardUp=true;
        }
        return cardUp;
    }

    public void AddVisibleFace(int index)
    {
        if(visibleFaces[0] == -1)
        {
            visibleFaces[0]=index;
        }
        else if(visibleFaces[1] == -2)
        {
            visibleFaces[1]=index;
        }
    }

    public void RemoveVisibleFace(int index)
    {
        if(visibleFaces[0] == index)
        {
            visibleFaces[0]= -1;
        }
        else if(visibleFaces[1] == index)
        {
            visibleFaces[1]= -2;
        } 
    }

    public bool CheckMatch() //comparar cartes correctes
    {
        bool success=false;
        if(visibleFaces[0] == visibleFaces[1])
        {
            visibleFaces[0]= -1;
            visibleFaces[1]= -2;
            success=true;
        }
        return success;
    }

    private void Awake()
    {
        token = GameObject.Find("Token");
    }

}
*/