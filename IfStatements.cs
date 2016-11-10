using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{

    public int Love;
    public int Hate;

	void Start ()
    {
	    if(Love > 10)
        {
            print("I'm in love!");
        }
        
        else if(Hate > 10)
        {
            print("I hate them!");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
