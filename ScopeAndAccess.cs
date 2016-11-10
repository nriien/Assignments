using UnityEngine;
using System.Collections;

public class ScopeAndAccess : MonoBehaviour
{

    public int books = 5; //this variable can be used by other scripts because it is public
    private int pens = 10; //this variable cannot because it is private

	void Start () {
        print("I have " + books + " books and " + pens + " pens.");
	}
	
}
