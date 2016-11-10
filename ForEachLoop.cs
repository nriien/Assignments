using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour
{

	
	void Start ()
    {
        string[] Boys = new string[4];

        Boys[0] = "Anthony";
        Boys[1] = "Tim";
        Boys[2] = "Jimmy";
        Boys[3] = "Clyde";

        foreach(string item in Boys)
        {
            print("His name is " + item);
        }
	}
	
	
}
