using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{

    private int NotePages = 0;

    void Start ()
    {
        while (NotePages < 5)
        {
            Debug.Log("I don't have enough paper for my assignment. I need to collect more paper.");
            NotePages++;
        }
           
	}
	
  
}
