using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        int IceCreamScoops = 0;

        do
        {
            print("I want another scoop!");
            IceCreamScoops++;
        } while (IceCreamScoops < 3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
